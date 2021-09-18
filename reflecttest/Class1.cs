using System;
using System.Linq.Expressions;

namespace ConsoleClientApp.reflecttest
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ObjAttr : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Property)]
    public class PropAttr : Attribute
    {

    }

    public interface IMapperTo
    {
    }

    public interface IMapperTo<T> : IMapperTo
    {
    }

    public interface IMapperFrom
    {
    }

    public interface IMapperFrom<T> : IMapperTo
    {
    }


    public class C1
    {
        public string name1 { get; set; }
        public string name2 { get; set; }

    }

    public class C2
    {
        public string name1 { get; set; }
        public string name3 { get; set; }
    }

    public class C3 { }

    public interface IMappingExpressionBase<TSource, TDestination, out TMappingExpression> where TMappingExpression : IMappingExpressionBase<TSource, TDestination, TMappingExpression> { }

    public interface IMemberConfigurationExpression<TSource, TDestination, TMember> { }

    public interface IMappingExpression<TSource, TDestination> : IMappingExpressionBase<TSource, TDestination, IMappingExpression<TSource, TDestination>> { }


    
    public static class GenericClass2  
    {
        public static void Test()
        {
            var obj = new C1();
            obj.ForMember(o => o.name1);
        }
        public static Expression<Func<TSource, TDestination>> ForMember<TSource, TDestination>(this TSource source, Expression<Func<TSource, TDestination>> expression)
        {
            throw new Exception();
        }
    }

}
