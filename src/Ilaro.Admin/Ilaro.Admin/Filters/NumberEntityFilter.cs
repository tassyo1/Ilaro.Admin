﻿using System;
using System.Collections.Generic;
using System.Linq;
using Ilaro.Admin.Core;
using Ilaro.Admin.Extensions;
using Resources;

namespace Ilaro.Admin.Filters
{
    public class NumberEntityFilter : BaseFilter<Number>
    {
        public override Property Property { get; protected set; }
        public override sealed IList<TemplatedSelectListItem> Options { get; protected set; }
        public override sealed string Value { get; protected set; }
        public override bool DisplayInUI { get { return true; } }

        public NumberEntityFilter(Property property, string value = "")
            : base(property, value)
        {

            Options.Add(new TemplatedSelectListItem(IlaroAdminResources.All, String.Empty, Value));

            if (Options.Any(x => x.Selected))
                Options.Add(new TemplatedSelectListItem(String.Empty, Value, String.Empty, Templates.Filter.Number));
            else
                Options.Add(new TemplatedSelectListItem(String.Empty, Value, Value, Templates.Filter.Number));
        }

        public override string GetSqlCondition(string alias, ref List<object> args)
        {
            var sql = "{0}{1} = @{2}".Fill(alias, Property.Column, args.Count);
            args.Add(Value);

            return sql;
        }
    }
}