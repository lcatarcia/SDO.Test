using SDO.Infrastructure.Sql.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Function.CreateParquet8.Utilities
{
    internal static class FileMapper
    {
        public static IFileModel Map(IFileModel fileModel, List<string> data)
        {
            PropertyInfo[] properties = fileModel.GetType().GetProperties();
            int index = 0;
            foreach (PropertyInfo property in properties)
            {
                if (property.Name != "SequenceNumber")
                {
                    property?.SetValue(fileModel, data[index]);
                    index++;
                }
            }
            return fileModel;
        }
    }
}
