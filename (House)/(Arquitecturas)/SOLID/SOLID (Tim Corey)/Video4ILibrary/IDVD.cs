using System.Collections.Generic;

namespace Video4ILibrary
{
    public interface IDVD
    {
        List<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }
    }

}
