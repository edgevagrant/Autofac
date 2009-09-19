﻿using NUnit.Framework;

namespace Autofac.Tests.Configuration
{
    static class AssertionHelpers
    {
        public static void AssertRegistered<TService>(this IComponentContext context)
        {
            Assert.IsTrue(context.IsRegistered<TService>());
        }

        public static void AssertNotRegistered<TService>(this IComponentContext context)
        {
            Assert.IsFalse(context.IsRegistered<TService>());
        }

        public static void AssertRegistered(this IComponentContext context, string service)
        {
            Assert.IsTrue(context.IsRegistered(service));
        }

        public static void AssertNotRegistered(this IComponentContext context, string service)
        {
            Assert.IsFalse(context.IsRegistered(service));
        }
    }
}