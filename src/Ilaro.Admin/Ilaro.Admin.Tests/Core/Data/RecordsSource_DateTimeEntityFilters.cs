﻿using System;
using System.Collections.Generic;
using System.Linq;
using Ilaro.Admin.Core;
using Ilaro.Admin.Core.Data;
using Ilaro.Admin.Filters;
using Ilaro.Admin.Tests.TestModels.Northwind;
using Xunit;

namespace Ilaro.Admin.Tests.Core.Data
{
    public class RecordsSource_DateTimeEntityFilters : SqlServerDatabaseTest
    {
        private readonly IFetchingRecords _source;
        private Entity _entity;
        private Property _property;
        private IKnowTheTime _fakeClock;

        public RecordsSource_DateTimeEntityFilters()
        {
            _fakeClock = new FakeClock(
                () => new DateTime(2015, 7, 20),
                () => new DateTime(2015, 7, 20));

            DB.Orders.Insert(ShipCity: "City1", OrderDate: "2015.07.20 11:33");
            DB.Orders.Insert(ShipCity: "City2", OrderDate: "2015.07.19 11:33");
            DB.Orders.Insert(ShipCity: "City3", OrderDate: "2015.06.20 11:33");
            DB.Orders.Insert(ShipCity: "City4", OrderDate: "2014.08.20 11:33");

            _source = new RecordsSource(new Notificator());
            Admin.AddEntity<Order>();
            Admin.SetForeignKeysReferences();
            Admin.ConnectionStringName = ConnectionStringName;
            _entity = Admin.EntitiesTypes
                .FirstOrDefault(x => x.Name == "Order");
            _property = _entity["OrderDate"];
        }

        [Fact]
        public void empty_date_time_filter_should_return_four_records()
        {
            var result = _source.GetRecords(_entity);
            Assert.Equal(4, result.Records.Count);

            var filters = new List<IEntityFilter>();
            result = _source.GetRecords(_entity, filters);
            Assert.Equal(4, result.Records.Count);

            filters = new List<IEntityFilter>
            {
                new DateTimeEntityFilter(_fakeClock)
            };
            result = _source.GetRecords(_entity, filters);
            Assert.Equal(4, result.Records.Count);

            var filter = new DateTimeEntityFilter(_fakeClock);
            filter.Initialize(_property);
            filters = new List<IEntityFilter>
            {
                filter
            };
            result = _source.GetRecords(_entity, filters);
            Assert.Equal(4, result.Records.Count);
        }

        [Theory]
        [InlineData("2015.07.20", 1)]
        [InlineData("2015.07.19", 1)]
        [InlineData("2015.07.13-2015.07.20", 2)]
        [InlineData("2015.06.20-2015.07.20", 3)]
        [InlineData("2015.04.20-2015.07.20", 3)]
        [InlineData("2015.01.20-2015.07.20", 3)]
        [InlineData("2014.07.20-2015.07.20", 4)]
        [InlineData("2014.07.20-", 4)]
        [InlineData("-2015.07.20", 4)]
        [InlineData("-2014.08.20", 1)]
        [InlineData("2015.07.20-", 1)]
        public void date_time_filter_with_provided_value__returned_count_results_should_match_with_provided_count(string value, int resultsCount)
        {
            var filter = new DateTimeEntityFilter(_fakeClock);
            filter.Initialize(_property, value);
            var filters = new List<IEntityFilter>
            {
                filter
            };
            var result = _source.GetRecords(_entity, filters);
            Assert.Equal(resultsCount, result.Records.Count);
        }
    }
}
