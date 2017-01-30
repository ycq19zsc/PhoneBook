﻿using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ZSC.PhoneBook.EntityFramework;

namespace ZSC.PhoneBook
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(PhoneBookCoreModule))]
    public class PhoneBookDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PhoneBookDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
