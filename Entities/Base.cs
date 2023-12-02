
using System.ComponentModel.DataAnnotations.Schema;

namespace minozas_catering_api_dotnet.Entities
{
    public abstract class Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }
    }
}
