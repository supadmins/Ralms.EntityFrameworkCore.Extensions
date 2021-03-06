﻿/*
 *          Copyright (c) 2018 Rafael Almeida (ralms@ralms.net)
 *
 *           Ralms.Microsoft.EntitityFrameworkCore.Extensions
 *
 * THIS MATERIAL IS PROVIDED AS IS, WITH ABSOLUTELY NO WARRANTY EXPRESSED
 * OR IMPLIED.  ANY USE IS AT YOUR OWN RISK.
 *
 * Permission is hereby granted to use or copy this program
 * for any purpose,  provided the above notices are retained on all copies.
 * Permission to modify the code and to distribute modified code is granted,
 * provided the above notices are retained, and a notice that the code was
 * modified is included with the above copyright notice.
 *
 */

using Microsoft.EntityFrameworkCore.Infrastructure;
using Ralms.EntityFrameworkCore.Extensions;

namespace Microsoft.EntityFrameworkCore
{
    public static class RalmsDbContextOptionsBuilderExtensions
    {
        public static DbContextOptionsBuilder RalmsExtendFunctions(this DbContextOptionsBuilder optionsBuilder)
        {
            var extension = optionsBuilder.Options.FindExtension<RalmsExOptionsExtension>()
                ?? new RalmsExOptionsExtension();

            ((IDbContextOptionsBuilderInfrastructure)optionsBuilder).AddOrUpdateExtension(extension);

            return optionsBuilder;
        }

        public static DbContextOptionsBuilder<TContext> RalmsExtendFunctions<TContext>(
            this DbContextOptionsBuilder<TContext> optionsBuilder)
            where TContext : DbContext
            => (DbContextOptionsBuilder<TContext>)RalmsExtendFunctions((DbContextOptionsBuilder)optionsBuilder);

#warning Use in the future!
        public static DbContextOptionsBuilder<TContext> RalmsExtendSqlServer<TContext>(
            this DbContextOptionsBuilder<TContext> optionsBuilder)
            where TContext : DbContext
            => (DbContextOptionsBuilder<TContext>)RalmsExtendFunctions((DbContextOptionsBuilder)optionsBuilder);

        public static DbContextOptionsBuilder<TContext> RalmsExtendSqlite<TContext>(
           this DbContextOptionsBuilder<TContext> optionsBuilder)
           where TContext : DbContext
           => (DbContextOptionsBuilder<TContext>)RalmsExtendFunctions((DbContextOptionsBuilder)optionsBuilder);

        public static DbContextOptionsBuilder<TContext> RalmsExtendFirebird<TContext>(
           this DbContextOptionsBuilder<TContext> optionsBuilder)
           where TContext : DbContext
           => (DbContextOptionsBuilder<TContext>)RalmsExtendFunctions((DbContextOptionsBuilder)optionsBuilder);

        public static DbContextOptionsBuilder<TContext> RalmsExtendPostgres<TContext>(
           this DbContextOptionsBuilder<TContext> optionsBuilder)
           where TContext : DbContext
           => (DbContextOptionsBuilder<TContext>)RalmsExtendFunctions((DbContextOptionsBuilder)optionsBuilder);
    }
}
