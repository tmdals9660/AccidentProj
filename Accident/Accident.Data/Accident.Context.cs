﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Accident.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AccidentEntities : DbContext
    {
        public AccidentEntities()
            : base("name=AccidentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccidentFiled> AccidentFileds { get; set; }
        public virtual DbSet<AccidentType> AccidentTypes { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AttackerType> AttackerTypes { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Incident> Incidents { get; set; }
        public virtual DbSet<RoadForm> RoadForms { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<VictimType> VictimTypes { get; set; }
        public virtual DbSet<Violation> Violations { get; set; }
    }
}
