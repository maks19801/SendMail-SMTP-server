﻿using System;
using System.Net;
using System.Net.Mail;

namespace SMTP
{
    class Program
    {
        static void Main(string[] args)
        {

            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("somemail@gmail.com", "Tom");
            // кому отправляем
            MailAddress to = new MailAddress("maks19801@gmail.com");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Тест";
            // текст письма
            m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("maks19801@gmail.com", "password");
            
            smtp.EnableSsl = true;
            smtp.SendAsync(m, "Mail sent");
            
           
            Console.Read();
        }
    }
}
