using AttributeS.CustomValidatorMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.ValidatorServices
{
    public class ValidatorService<T>
    {
        public void CheckAtribute(T entity, Type type)
        {
            List<PropertyInfo> propertyInfos = entity.GetType().GetRuntimeProperties().Where(x => Attribute.IsDefined(x, type)).ToList();

            foreach (var item in propertyInfos)
            {
                string result = item.GetValue(entity).ToString();

                if (!CustomValidator.CheckEmail(result))
                {

                }
                if (!CustomValidator.CheckPassword(result))
                {

                }
            }
        }
    }
}
