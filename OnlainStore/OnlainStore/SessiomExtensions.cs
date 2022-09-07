using System;
using OlineStore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using LanguageExt;
using MaxMind.Db;

namespace OlineStore
{
    public static class SessiomExtensions
    {
        private const string key = "Cart";
        public static void Set(this ISession session, Cart value)
        {
            if (value == null)
                return;

            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream, Encoding.UTF8, true))
            {
                writer.Write(value.Items.Count);

                foreach (var item in value.Items)
                {
                    writer.Write(item.Key);
                    writer.Write(item.Value);
                }

                writer.Write(value.Amount);

                session.Set(key, stream.ToArray());

            }
        }

        public static bool TryGetCart(this ISession session, out Cart value)
        {
            if (session.TryGetValue(key, out byte[] buffer))
            {
                using (var stream = new MemoryStream(buffer))
                using (var reader = new BinaryReader(stream, Encoding.UTF8, true))
                {
                    value = new Cart();

                    var length = reader.ReadInt32();

                    for (int i = 0; i < length; i++)
                    {
                        var productId = reader.ReadInt32();
                        var count = reader.ReadInt32();

                        value.Items.Add(productId, count);
                    }

                    value.Amount = reader.ReadDecimal();

                    return true;
                }
            }

            value = null;
            return false;
        }
    }
}
