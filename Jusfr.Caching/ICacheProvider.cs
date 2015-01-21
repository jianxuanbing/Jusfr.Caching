﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jusfr.Caching {
    public interface ICacheProvider {
        Boolean TryGet<T>(String key, out T value);
        T GetOrCreate<T>(String key, Func<T> function);
        T GetOrCreate<T>(String key, Func<String, T> factory);
        void Overwrite<T>(String key, T value);
        void Expire(String key);
    }
}