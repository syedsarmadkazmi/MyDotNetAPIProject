using System.Linq.Expressions;

public static class IQueryableExtensions
{
    // CustomSortBy method to handle dynamic sorting
    public static IQueryable<T> CustomSortBy<T>(this IQueryable<T> source, string sortBy, string sortOrder)
    {
        if (string.IsNullOrEmpty(sortBy))
        {
            return source; // No sorting applied if sortBy is null or empty
        }

        // Get the type of the entity
        var entityType = typeof(T);

        // Get the property to sort by
        var property = entityType.GetProperty(sortBy);

        if (property == null)
        {
            return source; // Return the original source if the property doesn't exist
        }

        // Create the expression tree for sorting
        var parameter = Expression.Parameter(entityType, "p");
        var propertyAccess = Expression.MakeMemberAccess(parameter, property);
        var orderByExpression = Expression.Lambda(propertyAccess, parameter);

        // Determine whether to sort in ascending or descending order
        string methodName = sortOrder == "desc" ? "OrderByDescending" : "OrderBy";

        // Call the corresponding OrderBy or OrderByDescending method
        var resultExpression = Expression.Call(
            typeof(Queryable),
            methodName,
            new Type[] { entityType, property.PropertyType },
            source.Expression,
            Expression.Quote(orderByExpression));

        return source.Provider.CreateQuery<T>(resultExpression);
    }
}