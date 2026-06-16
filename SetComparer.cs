using System;
using System.Collections.Generic;

public static class SetComparer
{
    public static bool AreSetsEquivalent(IEnumerable<int> first, IEnumerable<int> second)
    {
        ArgumentNullException.ThrowIfNull(first);
        ArgumentNullException.ThrowIfNull(second);

        HashSet<int> setA = new HashSet<int>(first);
        HashSet<int> setB = new HashSet<int>(second);

        return setA.SetEquals(setB);
    }
}
