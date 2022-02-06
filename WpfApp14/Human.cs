using System.ComponentModel;
using System.Globalization;
using System.Windows.Controls;

namespace WpfApp14
{
    public class Human : IDataErrorInfo
    {
        public string this[string columnName]
        {
            get {
                string errorInfo = null;
                switch (columnName)
                {
                    case "Age":
                        if (Age > 120)
                            errorInfo= "Введен слишком большой возраст";
                        else if (Age < 0)
                            errorInfo= "Возраст не может быть отрицательным";
                        break;
                    case "Name":
                        if (Name.Length < 2)
                            errorInfo = "Имя слишком короткое";
                        break;
                }
                return errorInfo;
            }
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public string Error { get; private set; }
    }

}