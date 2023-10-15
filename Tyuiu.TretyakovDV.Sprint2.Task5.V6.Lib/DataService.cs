using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.TretyakovDV.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res;

            switch (value1)
            {
                case 1:
                    res = " Пики";
                    switch (value2)
                    {
                        case 6:
                            res = "Шестерка" + res;
                            break;
                        case 7:
                            res = "Семерка" + res;
                            break;
                        case 8:
                            res = "Восьмерка" + res;
                            break;
                        case 9:
                            res = "Девятка" + res;
                            break;
                        case 10:
                            res = "Десятка" + res;
                            break;
                        case 11:
                            res = "Валет" + res;
                            break;
                        case 12:
                            res = "Дама" + res;
                            break;
                        case 13:
                            res = "Король" + res;
                            break;
                        case 14:
                            res = "Туз" + res;
                            break;
                        default:
                            res = "Error";
                            break;
                    }
                    break;
                case 2:
                    res = " Трефы";
                    switch (value2)
                    {
                        case 6:
                            res = "Шестерка" + res;
                            break;
                        case 7:
                            res = "Семерка" + res;
                            break;
                        case 8:
                            res = "Восьмерка" + res;
                            break;
                        case 9:
                            res = "Девятка" + res;
                            break;
                        case 10:
                            res = "Десятка" + res;
                            break;
                        case 11:
                            res = "Валет" + res;
                            break;
                        case 12:
                            res = "Дама" + res;
                            break;
                        case 13:
                            res = "Король" + res;
                            break;
                        case 14:
                            res = "Туз" + res;
                            break;
                        default:
                            res = "Error";
                            break;
                    }
                    break;
                case 3:
                    res = " Бубны";
                    switch (value2)
                    {
                        case 6:
                            res = "Шестерка" + res;
                            break;
                        case 7:
                            res = "Семерка" + res;
                            break;
                        case 8:
                            res = "Восьмерка" + res;
                            break;
                        case 9:
                            res = "Девятка" + res;
                            break;
                        case 10:
                            res = "Десятка" + res;
                            break;
                        case 11:
                            res = "Валет" + res;
                            break;
                        case 12:
                            res = "Дама" + res;
                            break;
                        case 13:
                            res = "Король" + res;
                            break;
                        case 14:
                            res = "Туз" + res;
                            break;
                        default:
                            res = "Error";
                            break;
                    }
                    break;
                case 4:
                    res = " Червы";
                    switch (value2)
                    {
                        case 6:
                            res = "Шестерка" + res;
                            break;
                        case 7:
                            res = "Семерка" + res;
                            break;
                        case 8:
                            res = "Восьмерка" + res;
                            break;
                        case 9:
                            res = "Девятка" + res;
                            break;
                        case 10:
                            res = "Десятка" + res;
                            break;
                        case 11:
                            res = "Валет" + res;
                            break;
                        case 12:
                            res = "Дама" + res;
                            break;
                        case 13:
                            res = "Король" + res;
                            break;
                        case 14:
                            res = "Туз" + res;
                            break;
                        default:
                            res = "Error";
                            break;
                    }
                    break;
                default:
                    res = "Error";
                    break;
            }
            return res;
        }
    }
}