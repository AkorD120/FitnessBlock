﻿using FitnessBlock.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBlock.BL.Controller
{
    /// <summary>
    /// Контроллер пользователя.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь приложения.
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Создание нового контроллера пользователя.
        /// </summary>
        /// <param name="user"> Имя пользователя. </param>
        public UserController(string userName, string genderName, DateTime birthDate, double weight, double height)
        {
            // TODO: проверка.

            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDate, weight, height);
        }

        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
            }

            // TODO: Что делать, если пользователя не прочитали?
        }

        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }                 
    }
}
