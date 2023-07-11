namespace RemoveInstanceIdFromQueryString;

public static class Library
{
    public static string? RemoveInstanceIdFromQueryString_Old(string query)
    {
        if (string.IsNullOrEmpty(query))
        {
            return null;
        }

        var parameters = query.Split('&');
        var newParams = new List<string>();
        foreach (var p in parameters)
        {
            var kvp = p.Split('=');
            if (kvp.Length == 2 &&
                !kvp[0].Equals("instanceId", StringComparison.OrdinalIgnoreCase))
            {
                newParams.Add(p);
            }
        }

        return string.Join('&', newParams);
    }
    
    public static string? RemoveInstanceIdFromQueryString_New(string query)
    {
        if (query == string.Empty)
            return null;
    
        var start = query.IndexOf("instanceId", StringComparison.OrdinalIgnoreCase);
        if (start == -1)
            return query;
    
        var end = start + "instanceId".Length;
        while (end < query.Length &&
               query[end] != '&')
            end++;

        var hasPrevParameter = start > 0;  
        var hasNextParameter = end < query.Length;

        if (hasPrevParameter)
            start--; 
        else if (hasNextParameter)
            end++;
        
        var span = query.AsSpan();
        var left = span[..start];
        var right = span[end..];
        var result = string.Concat(left, right);
        return result;
    }
}