﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Study_Kamalov_wpf_320P.DbModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Study_Baza_Dolgov_320PEntities : DbContext
    {
        public Study_Baza_Dolgov_320PEntities()
            : base("name=Study_Baza_Dolgov_320PEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Academiki> Academiki { get; set; }
        public virtual DbSet<Disciplina> Disciplina { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Enginer> Enginer { get; set; }
        public virtual DbSet<Exsamen> Exsamen { get; set; }
        public virtual DbSet<Fackultet> Fackultet { get; set; }
        public virtual DbSet<Gimnazisti> Gimnazisti { get; set; }
        public virtual DbSet<Jivotnie_Dolgov> Jivotnie_Dolgov { get; set; }
        public virtual DbSet<Kafedra> Kafedra { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<Strani> Strani { get; set; }
        public virtual DbSet<Strani_Dolgov> Strani_Dolgov { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<Tsveti_Dolgov> Tsveti_Dolgov { get; set; }
        public virtual DbSet<Ycheniki> Ycheniki { get; set; }
        public virtual DbSet<Ypravlinie_Dolgov> Ypravlinie_Dolgov { get; set; }
        public virtual DbSet<Zav_kaf> Zav_kaf { get; set; }
        public virtual DbSet<Zayavka> Zayavka { get; set; }
        public virtual DbSet<Academiki_Det> Academiki_Det { get; set; }
    }
}
