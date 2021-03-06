﻿using System.IO;
using System.Linq;
using System.Web.Mvc;
using Ilaro.Admin.Models;

namespace Ilaro.Admin.Extensions
{
    public static class UrlHelperExtensions
    {
        public static string GetImageMinPath(
            this UrlHelper urlHelper,
            CellValue value)
        {
            if (value.AsString.IsNullOrEmpty())
            {
                return null;
            }

            var settings = value.Property.FileOptions.Settings.LastOrDefault();
            var path = Path.Combine("~/", value.Property.FileOptions.Path, settings.SubPath, value.AsString).Replace("\\", "/");

            return urlHelper.Content(path);
        }

        public static string GetImageBigPath(
            this UrlHelper urlHelper,
            CellValue value)
        {
            if (value.AsString.IsNullOrEmpty())
            {
                return null;
            }

            var settings = value.Property.FileOptions.Settings.FirstOrDefault();
            var path = Path.Combine("~/", value.Property.FileOptions.Path, settings.SubPath, value.AsString).Replace("\\", "/");

            return urlHelper.Content(path);
        }

        public static string GetFilePath(
            this UrlHelper urlHelper,
            CellValue value)
        {
            if (value.AsString.IsNullOrEmpty())
            {
                return null;
            }

            var path = Path.Combine("~/", value.Property.FileOptions.Path, value.AsString).Replace("\\", "/");

            return urlHelper.Content(path);
        }
    }
}