﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diploma_IS_of_Vladkhleb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Diploma_DB_of_VladkhlebEntities : DbContext
    {
        public Diploma_DB_of_VladkhlebEntities()
            : base("name=Diploma_DB_of_VladkhlebEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Брак> Бракs { get; set; }
        public virtual DbSet<ГОСТ> ГОСТs { get; set; }
        public virtual DbSet<Готовая_партия> Готовая_партияs { get; set; }
        public virtual DbSet<Документ_Передача_брака_в_переработку> Документ_Передача_брака_в_переработкуs { get; set; }
        public virtual DbSet<Должность> Должностьs { get; set; }
        public virtual DbSet<Заказ_на_выпускаемую_продукцию> Заказ_на_выпускаемую_продукциюs { get; set; }
        public virtual DbSet<Заявка_на_поставку_сырья> Заявка_на_поставку_сырьяs { get; set; }
        public virtual DbSet<Оборудование> Оборудованиеs { get; set; }
        public virtual DbSet<Образец> Образецs { get; set; }
        public virtual DbSet<Подготовленное_сырье> Подготовленное_сырьеs { get; set; }
        public virtual DbSet<Поставщик> Поставщикs { get; set; }
        public virtual DbSet<Прогноз_для_нового_сырья> Прогноз_для_нового_сырьяs { get; set; }
        public virtual DbSet<Продукция> Продукцияs { get; set; }
        public virtual DbSet<Работник> Работникs { get; set; }
        public virtual DbSet<Разрешение_на_отправку> Разрешение_на_отправкуs { get; set; }
        public virtual DbSet<Строка_графика_работ> Строка_графика_работs { get; set; }
        public virtual DbSet<Строка_заказа_на_выпускаемую_продукцию> Строка_заказа_на_выпускаемую_продукциюs { get; set; }
        public virtual DbSet<Строка_заявки_на_поставку_сырья> Строка_заявки_на_поставку_сырьяs { get; set; }
        public virtual DbSet<Строка_плана_перевозок> Строка_плана_перевозокs { get; set; }
        public virtual DbSet<Строка_учета_отпуска_сырья_в_производство> Строка_учета_отпуска_сырья_в_производствоs { get; set; }
        public virtual DbSet<Сырье> Сырьеs { get; set; }
        public virtual DbSet<Технология_производства> Технология_производстваs { get; set; }
        public virtual DbSet<ТОРГ_1_Акт_о_приемке_товаров> ТОРГ_1_Акт_о_приемке_товаровs { get; set; }
        public virtual DbSet<ТОРГ_8_Заказ_отборочный_лист> ТОРГ_8_Заказ_отборочный_листs { get; set; }
        public virtual DbSet<ТОРГ_9_Упаковочный_ярлык> ТОРГ_9_Упаковочный_ярлыкs { get; set; }
        public virtual DbSet<Учет_отпуска_сырья_в_производство> Учет_отпуска_сырья_в_производствоs { get; set; }
    }
}