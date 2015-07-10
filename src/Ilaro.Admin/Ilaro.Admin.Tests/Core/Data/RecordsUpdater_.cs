﻿using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using Ilaro.Admin.Core;
using Ilaro.Admin.Core.Data;
using Ilaro.Admin.Extensions;
using Ilaro.Admin.Tests.TestModels.Northwind;
using Xunit;

namespace Ilaro.Admin.Tests.Core.Data
{
    public class RecordsUpdater_ : SqlServerDatabaseTest
    {
        private readonly IFetchingRecords _source;
        private readonly IUpdatingRecords _updater;
        private readonly IProvidingUser _user;
        private Entity _entity;
        private int _productId;

        public RecordsUpdater_()
        {
            _source = new RecordsSource(new Notificator());
            _user = A.Fake<IProvidingUser>();
            A.CallTo(() => _user.Current()).Returns("Test");
            var executor = new DbCommandExecutor(_user);
            _updater = new RecordsUpdater(executor, _source);
            Admin.AddEntity<Product>();
            Admin.SetForeignKeysReferences();
            Admin.ConnectionStringName = ConnectionStringName;

            _productId = DB.Products.Insert(ProductName: "Product").ProductID;
            _entity = _source.GetEntityWithData("Product", _productId.ToString());
        }

        [Fact]
        public void updates_record_and_does_not_create_entity_change_when_is_not_added()
        {
            _entity["ProductName"].Value.Raw = "Product2";
            _updater.Update(_entity);

            var products = (List<Product>)DB.Products.All();
            Assert.Equal(1, products.Count);
            Assert.Equal("Product2", products.First().ProductName);

            A.CallTo(() => _user.Current()).MustNotHaveHappened();
            var changes = DB.EntityChanges.All().ToList();
            Assert.Equal(0, changes.Count);
        }

        [Fact]
        public void updates_record_and_does_create_entity_change_when_is_added()
        {
            Admin.AddEntity<EntityChange>();
            _entity["ProductName"].Value.Raw = "Product2";
            _updater.Update(_entity);

            var products = (List<Product>)DB.Products.All();
            Assert.Equal(1, products.Count);
            Assert.Equal("Product2", products.First().ProductName);

            A.CallTo(() => _user.Current()).MustHaveHappened();
            var changes = DB.EntityChanges.All().ToList();
            Assert.Equal(1, changes.Count);
        }

        [Fact]
        public void updates_record_with_one_to_many_foreign_property()
        {
            var categoryId = DB.Categories.Insert(CategoryName: "Category").CategoryID;
            Admin.AddEntity<Category>();
            _entity["ProductName"].Value.Raw = "Product";
            _entity["Discontinued"].Value.Raw = false;
            _entity["Category"].Value.Raw = categoryId;
            _updater.Update(_entity);

            var products = (List<dynamic>)DB.Products.All().ToList();
            Assert.Equal(1, products.Count);
            Assert.Equal(categoryId, products.First().CategoryID);
        }

        [Fact]
        public void updates_record_with_many_to_one_foreign_property()
        {
            var category = DB.Categories.Insert(CategoryName: "Category");
            var product2 = DB.Products.Insert(ProductName: "Product2", CategoryId: category.CategoryID);

            Admin.AddEntity<Category>();
            Admin.SetForeignKeysReferences();
            _entity =
                Admin.EntitiesTypes.FirstOrDefault(x => x.Name == "Category");
            _entity = _source.GetEntityWithData("Category", category.CategoryID.ToString());
            _entity["CategoryName"].Value.Raw = "Category";
            _entity["Products"].Value.Values = new List<object> { _productId };
            _updater.Update(_entity);

            var categories = (List<dynamic>)DB.Categories.All().ToList();
            Assert.Equal(1, categories.Count);
            var products = (List<dynamic>)DB.Products.All().ToList();
            Assert.Equal(2, products.Count);
            var product = products.First(x => x.ProductID == _productId);
            product2 = products.First(x => x.ProductID == product2.ProductID);
            Assert.Null(product2.CategoryID);
            Assert.Equal(category.CategoryID, product.CategoryID);
        }
    }
}
