﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBlock.BL.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    class User
    {
        #region Свойства
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Рост.
        /// </summary>
        public double Height { get; set; }
        #endregion

        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="name"> Имя пользователя. </param>
        /// <param name="gender"> Пол. </param>
        /// <param name="birthDate"> Дата рождения. </param>
        /// <param name="weight"> Вес. </param>
        /// <param name="height"> Рост. </param>
        public User(string name,
            Gender gender,
            DateTime birthDate,
            double weight,
            double height)
        {

            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не можеть быть пустым или null.", nameof(name));
            }

            if (Gender == null)
            {
                throw new ArgumentNullException("Пол не можеть быть null.", nameof(gender));

            }

            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentNullException("Невозможная дата рождения.", nameof(birthDate));
            }

            if (weight <= 0)
            {
                throw new ArgumentNullException("Вес не можеть быть меньше либо равен нулю.", nameof(weight));
            }

            if (height <= 0)
            {
                throw new ArgumentNullException("Рост не можеть быть меньше либо равен нулю.", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}