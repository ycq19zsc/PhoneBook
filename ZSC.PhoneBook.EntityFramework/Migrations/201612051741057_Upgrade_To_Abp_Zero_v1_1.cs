namespace ZSC.PhoneBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Upgrade_To_Abp_Zero_v1_1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AbpUsers", "EmailConfirmationCode", c => c.String(maxLength: 328));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AbpUsers", "EmailConfirmationCode", c => c.String(maxLength: 128));
        }
    }
}
