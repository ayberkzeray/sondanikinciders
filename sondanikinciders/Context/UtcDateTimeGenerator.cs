using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondanikinciders.Context
{
    public class UtcDateTimeGenerator : ValueGenerator<DateTime>
    {
        /// <summary>
        ///     Gets a value indicating whether the values generated are temporary or permanent. This implementation
        ///     always returns false, meaning the generated values will be saved to the database.
        /// </summary>
        public override bool GeneratesTemporaryValues => false;

        /// <summary>
        ///     Gets a value to be assigned to a property.
        /// </summary>
        /// <param name="entry">
        ///     The change tracking entry of the entity for which the value is being generated.
        /// </param>
        /// <returns>
        ///     The value to be assigned to a property.
        /// </returns>
        public override DateTime Next(EntityEntry entry) => DateTime.UtcNow;
    }
}
