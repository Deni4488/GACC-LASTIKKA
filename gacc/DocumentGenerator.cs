using System;

namespace gacc
{
    public static class DocumentGenerator
    {
        // Генерация документа по запросу
        static public void ShowDocumentOfDemand(int ID)
        {
            // данные запроса
            object[] data = DBImage.qdlta.GetDataByID(ID).Rows[0].ItemArray;
            int id = Convert.ToInt32(data[0]);
            DateTime date = Convert.ToDateTime(data[1]);
            string descr = data[2].ToString();
            int pid = Convert.ToInt32(data[3]);
            string pname = data[4].ToString();

            string HTML = "";
            // составление HTML-кода 
            HTML += "<HTML>";
            HTML += "<HEAD>";
            HTML += "<TITLE>content</TITLE>";
            HTML += "</HEAD>";
            HTML += "<BODY>";
            HTML += "<FONT face=arial>";

            // Заголовок
            HTML += "<TABLE align=center><TR><TD>";
            HTML += "<TR><TD align=center><B>ОБЩЕСТВО С ОГРАНИЧЕННОЙ ОТВЕТСТВЕННОСТЬЮ \"ЛАСТИККА\"</B></TD></TR>";
            HTML += "<TR><TD align=center><I>115280, город Москва, 1-Й Автозаводский проезд, д. 4 к. 1, помещ. 41/1/3</I></TD></TR>";
            HTML += "<TR><TD align=center>ЗАПРОС №  <B>" + id.ToString("0000") + "</B></TD></TR>";
            HTML += "<TR><TD align=center>ОТ <I><U>" + date.ToLongDateString() + "</U></I></TD></TR>";
            HTML += "<TR><TD align=center> -------------------------------------------------- </TD></TR>";
            HTML += "</TABLE>";

            // Данные поставщика
            HTML += "<TABLE width=400>";
            HTML += "<TR>";
            HTML += "<TD width=100><B>ПОСТАВЩИК</B></TD><TD></TD>";
            HTML += "</TR>";
            HTML += "<TR>";
            HTML += "<TD>Код:</TD><TD>" + pid.ToString("0000") + "</TD>";
            HTML += "</TR>";
            HTML += "<TR>";
            HTML += "<TD></TD><TD>" + pname + "</TD>";
            HTML += "</TR>";
            HTML += "</TABLE>";

            // данные состава запроса
            int pos = 0, count = 0;
            int good_id, cnt;
            string man_name, g_name, model;
            // получение из БД состава 
            DBImage.qdcldt = DBImage.qgclta.GetDataByByID(id);

            // Основной заказ
            HTML += "<TABLE align='center'><TR><TD>Запрашиваемый состав товаров:</TD></TR></TABLE>";
            HTML += "<TABLE align=\"center\" border=\"1\" cellpadding=\"0\" cellspacing=\"0\" frame=\"border\" rules = \"cols\">";
            HTML += "<TR>";
            HTML += "<TD>";
            HTML += "Артикул";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Производитель";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Номенклатурная группа";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Модель (тип, спецификация)";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Кол-во";
            HTML += "</TD>";
            HTML += "</TR>";
            if (DBImage.qdcldt.Rows.Count > 0)
            {
                for (int i = 0; i < DBImage.qdcldt.Rows.Count; i++)
                {
                    good_id = Convert.ToInt32(DBImage.qdcldt.Rows[i].ItemArray[1]);//артикул
                    cnt = Convert.ToInt32(DBImage.qdcldt.Rows[i].ItemArray[2]);//кол-во
                    man_name = DBImage.qdcldt.Rows[i].ItemArray[11].ToString();
                    g_name = DBImage.qdcldt.Rows[i].ItemArray[12].ToString();
                    model = DBImage.qdcldt.Rows[i].ItemArray[6].ToString();
                    HTML += "<TR>";
                    HTML += "<TD>";
                    HTML += good_id.ToString("0000");
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += man_name;
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += g_name;
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += model;
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += cnt.ToString();
                    HTML += "</TD>";
                    HTML += "</TR>";
                    pos++;
                    count += cnt;
                }
            }
            HTML += "</TABLE>";
            DBImage.qdcldt.Dispose();

            // Итоги
            HTML += "</br>";
            HTML += "<P align=center>ИТОГО:</br></<P>";
            HTML += "<TABLE width=330>";
            HTML += "<TR><TD width=200>ПОЗИЦИЙ</TD><TD width=30>                            </TD>";
            HTML += "<TD align=right>" + pos.ToString("000") + "</TD></TR>";
            HTML += "<TR><TD width=200>Товаров</TD><TD width=30>                            </TD>";
            HTML += "<TD align=right width=100>" + count.ToString("000") + "</TD width=30></TR>";
            HTML += "</TABLE>";

            // Комментарии
            HTML += "</br>";
            HTML += "<TABLE>";
            HTML += "<TR><TD><I>Примечания:</I></TD>";
            HTML += "<TD>" + descr + "</TD></TR>";
            HTML += "</TABLE>";

            // Подписи         
            HTML += "</br>";
            HTML += "<TABLE>";
            HTML += "<TR><TD>Составил: </TD><TD width=150></TD><TD>____-_____________-_____г./___________________/</TD></TR>";
            HTML += "<TR><TD>Согласовано: </TD><TD width=150></TD><TD>____-_____________-_____г./___________________/</TD></TR>";
            HTML += "<TR><TD>Директор: </TD><TD width=150></TD><TD>____-_____________-_____г./___________________/</TD></TR>";
            HTML += "</TABLE>";

            // Окончание документа
            HTML += "</FONT>";
            HTML += "</BODY>";
            HTML += "</HTML>";
            // возврат строки

            new WindowDocument(HTML).ShowDialog();
        }


        // --------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------


        // Генерация документа по поставке
        static public void ShowDocumentOfSupply(int ID)
        {
            // данные запроса
            object[] data = DBImage.qslta.GetDataByID(ID).Rows[0].ItemArray;
            int id = Convert.ToInt32(data[0]);
            DateTime date = Convert.ToDateTime(data[1]);            
            int sid = Convert.ToInt32(data[2]);
            int pid = Convert.ToInt32(data[3]);
            string descr = data[4].ToString();
            string shop = data[5].ToString();
            string pname = data[6].ToString();

            string HTML = "";
            // составление HTML-кода 
            HTML += "<HTML>";
            HTML += "<HEAD>";
            HTML += "<TITLE>content</TITLE>";
            HTML += "</HEAD>";
            HTML += "<BODY>";
            HTML += "<FONT face=arial>";

            // Заголовок
            HTML += "<TABLE align=center><TR><TD>";
            HTML += "<TR><TD align=center><B>ОБЩЕСТВО С ОГРАНИЧЕННОЙ ОТВЕТСТВЕННОСТЬЮ \"ЛАСТИККА\"</B></TD></TR>";
            HTML += "<TR><TD align=center><I>115280, город Москва, 1-Й Автозаводский проезд, д. 4 к. 1, помещ. 41/1/3</I></TD></TR>";
            HTML += "<TR><TD align=center>ПОСТАВКА №  <B>" + id.ToString("0000") + "</B></TD></TR>";
            HTML += "<TR><TD align=center>ОТ <I><U>" + date.ToLongDateString() + "</U></I></TD></TR>";
            HTML += "<TR><TD align=center> -------------------------------------------------- </TD></TR>";
            HTML += "</TABLE>";

            // Данные поставщика
            HTML += "<TABLE width=400>";
            HTML += "<TR>";
            HTML += "<TD width=100><B>ПОСТАВЩИК</B></TD><TD></TD>";
            HTML += "</TR>";
            HTML += "<TR>";
            HTML += "<TD>Код:</TD><TD>" + pid.ToString("0000") + "</TD>";
            HTML += "</TR>";
            HTML += "<TR>";
            HTML += "<TD></TD><TD>" + pname + "</TD>";
            HTML += "</TR>";
            HTML += "</TABLE>";

            // Данные магазина получателя
            HTML += "<TABLE width=400>";
            HTML += "<TR>";
            HTML += "<TD width=100><B>Получатель</B></TD><TD></TD>";
            HTML += "</TR>";
            HTML += "<TR>";
            HTML += "<TD>Код:</TD><TD>" + sid.ToString("0000") + "</TD>";
            HTML += "</TR>";
            HTML += "<TR>";
            HTML += "<TD></TD><TD>" + shop + "</TD>";
            HTML += "</TR>";
            HTML += "</TABLE>";

            // данные состава запроса
            int pos = 0, count = 0;
            int good_id, cnt;
            string man_name, g_name, model;
            // получение из БД состава 
            DBImage.qscldt = DBImage.qsclta.GetDataByByID(id);

            // Основной заказ
            HTML += "<TABLE align='center'><TR><TD>Состав поставки товаров:</TD></TR></TABLE>";
            HTML += "<TABLE align=\"center\" border=\"1\" cellpadding=\"0\" cellspacing=\"0\" frame=\"border\" rules = \"cols\">";
            HTML += "<TR>";
            HTML += "<TD>";
            HTML += "Артикул";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Производитель";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Номенклатурная группа";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Модель (тип, спецификация)";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Кол-во";
            HTML += "</TD>";
            HTML += "</TR>";
            if (DBImage.qscldt.Rows.Count > 0)
            {
                for (int i = 0; i < DBImage.qscldt.Rows.Count; i++)
                {
                    good_id = Convert.ToInt32(DBImage.qscldt.Rows[i].ItemArray[1]);//артикул
                    cnt = Convert.ToInt32(DBImage.qscldt.Rows[i].ItemArray[2]);//кол-во
                    man_name = DBImage.qscldt.Rows[i].ItemArray[11].ToString();
                    g_name = DBImage.qscldt.Rows[i].ItemArray[12].ToString();
                    model = DBImage.qscldt.Rows[i].ItemArray[6].ToString();
                    HTML += "<TR>";
                    HTML += "<TD>";
                    HTML += good_id.ToString("0000");
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += man_name;
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += g_name;
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += model;
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += cnt.ToString();
                    HTML += "</TD>";
                    HTML += "</TR>";
                    pos++;
                    count += cnt;
                }
            }
            HTML += "</TABLE>";
            DBImage.qscldt.Dispose();

            // Итоги
            HTML += "</br>";
            HTML += "<P align=center>ИТОГО:</br></<P>";
            HTML += "<TABLE width=330>";
            HTML += "<TR><TD width=200>ПОЗИЦИЙ</TD><TD width=30>                            </TD>";
            HTML += "<TD align=right>" + pos.ToString("000") + "</TD></TR>";
            HTML += "<TR><TD width=200>Товаров</TD><TD width=30>                            </TD>";
            HTML += "<TD align=right width=100>" + count.ToString("000") + "</TD width=30></TR>";
            HTML += "</TABLE>";

            // Комментарии
            HTML += "</br>";
            HTML += "<TABLE>";
            HTML += "<TR><TD><I>Примечания:</I></TD>";
            HTML += "<TD>" + descr + "</TD></TR>";
            HTML += "</TABLE>";

            // Подписи         
            HTML += "</br>";
            HTML += "<TABLE>";
            HTML += "<TR><TD>Принято: </TD><TD width=150></TD><TD>____-_____________-_____г./___________________/</TD></TR>";
            HTML += "<TR><TD>Доставлено: </TD><TD width=150></TD><TD>____-_____________-_____г./___________________/</TD></TR>";
            HTML += "</TABLE>";

            // Окончание документа
            HTML += "</FONT>";
            HTML += "</BODY>";
            HTML += "</HTML>";
            // возврат строки

            new WindowDocument(HTML).ShowDialog();
        }


        // --------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------


        // Генерация документа по продаже
        static public void ShowDocumentOfSell(int ID)
        {
            // данные запроса
            object[] data = DBImage.qselllta.GetDataByID(ID).Rows[0].ItemArray;
            int id = Convert.ToInt32(data[0]);
            DateTime date = Convert.ToDateTime(data[1]);
            string username = data[2].ToString();
            int cid = Convert.ToInt32(data[3]);
            int sid = Convert.ToInt32(data[4]);
            string client = data[5].ToString();
            string shopaddr = data[8].ToString();
            string shopphn = data[9].ToString();

            string HTML = "";
            // составление HTML-кода 
            HTML += "<HTML>";
            HTML += "<HEAD>";
            HTML += "<TITLE>content</TITLE>";
            HTML += "</HEAD>";
            HTML += "<BODY>";
            HTML += "<FONT face=arial>";

            // Заголовок
            HTML += "<TABLE align=center><TR><TD>";
            HTML += "<TR><TD align=center><B>ОБЩЕСТВО С ОГРАНИЧЕННОЙ ОТВЕТСТВЕННОСТЬЮ \"ЛАСТИККА\"</B></TD></TR>";
            HTML += "<TR><TD align=center><I>115280, город Москва, 1-Й Автозаводский проезд, д. 4 к. 1, помещ. 41/1/3</I></TD></TR>";
            HTML += "<TR><TD align=center>ПРОДАЖА №  <B>" + id.ToString("0000") + "</B></TD></TR>";
            HTML += "<TR><TD align=center>ОТ <I><U>" + date.ToLongDateString() + "</U></I></TD></TR>";
            HTML += "<TR><TD align=center>" + shopaddr + "</TD></TR>";
            HTML += "<TR><TD align=center>" + shopphn + "</TD></TR>";
            HTML += "<TR><TD align=center>ОФОРМИЛ: " + username + "</TD></TR>";
            HTML += "<TR><TD align=center> -------------------------------------------------- </TD></TR>";
            HTML += "</TABLE>";

            // Данные покупателя
            HTML += "<TABLE width=400>";
            HTML += "<TR>";
            HTML += "<TD width=100><B>Покупатель</B></TD><TD></TD>";
            HTML += "</TR>";
            HTML += "<TR>";
            HTML += "<TD>Код:</TD><TD>" + cid.ToString("0000") + "</TD>";
            HTML += "</TR>";
            HTML += "<TR>";
            HTML += "<TD></TD><TD>" + client + "</TD>";
            HTML += "</TR>";
            HTML += "</TABLE>";

            // данные состава продажи
            int pos = 0, count = 0;
            int good_id, cnt;
            string man_name, g_name, model;
            decimal price, summ = 0;
            // получение из БД состава 
            DBImage.qsellcldt = DBImage.qsellclta.GetDataByID(id);

            // Основной заказ
            HTML += "<TABLE align='center'><TR><TD>Состав чека:</TD></TR></TABLE>";
            HTML += "<TABLE align=\"center\" border=\"1\" cellpadding=\"0\" cellspacing=\"0\" frame=\"border\" rules = \"cols\">";
            HTML += "<TR>";
            HTML += "<TD>";
            HTML += "Артикул";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Производитель";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Номенклатурная группа";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Модель (тип, спецификация)";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Кол-во";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Цена";
            HTML += "</TD>";
            HTML += "<TD align=left>";
            HTML += "Сумма";
            HTML += "</TD>";
            HTML += "</TR>";
            if (DBImage.qsellcldt.Rows.Count > 0)
            {
                for (int i = 0; i < DBImage.qsellcldt.Rows.Count; i++)
                {
                    good_id = Convert.ToInt32(DBImage.qsellcldt.Rows[i].ItemArray[1]);//артикул
                    cnt = Convert.ToInt32(DBImage.qsellcldt.Rows[i].ItemArray[2]);//кол-во
                    man_name = DBImage.qsellcldt.Rows[i].ItemArray[11].ToString();
                    g_name = DBImage.qsellcldt.Rows[i].ItemArray[12].ToString();
                    model = DBImage.qsellcldt.Rows[i].ItemArray[6].ToString();
                    price = Convert.ToDecimal(DBImage.qsellcldt.Rows[i].ItemArray[18]);//кол-во
                    HTML += "<TR>";
                    HTML += "<TD>";
                    HTML += good_id.ToString("0000");
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += man_name;
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += g_name;
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += model;
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += cnt.ToString();
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += price.ToString("C0");
                    HTML += "</TD>";
                    HTML += "<TD align=left>";
                    HTML += (price * cnt).ToString("C0");
                    HTML += "</TD>";
                    HTML += "</TR>";
                    pos++;
                    count += cnt;
                    summ += price * cnt;
                }
            }
            HTML += "</TABLE>";
            DBImage.qsellcldt.Dispose();

            // Итоги
            HTML += "</br>";
            HTML += "<P align=center>ИТОГО:</br></<P>";
            HTML += "<TABLE width=330>";
            HTML += "<TR><TD width=200>ПОЗИЦИЙ</TD><TD width=30>                            </TD>";
            HTML += "<TD align=right>" + pos.ToString("000") + "</TD></TR>";
            HTML += "<TR><TD width=200>Товаров</TD><TD width=30>                            </TD>";
            HTML += "<TD align=right width=100>" + count.ToString("000") + "</TD width=30></TR>";
            HTML += "<TR><TD width=200>Общая сумма</TD><TD width=30>                            </TD>";
            HTML += "<TD align=right width=100>" + summ.ToString("C0") + "</TD width=30></TR>";
            HTML += "</TABLE>";

            // Окончание документа
            HTML += "</FONT>";
            HTML += "</BODY>";
            HTML += "</HTML>";
            // возврат строки

            new WindowDocument(HTML).ShowDialog();
        }
    }
}