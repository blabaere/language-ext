﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageExt
{
    public static class __ComposeExt
    {
        /// <summary>
        /// Function composition
        /// </summary>
        /// <returns>v => b(a(v))</returns>
        [Pure]
        public static Func<T1, T3> Compose<T1, T2, T3>(this Func<T2, T3> b, Func<T1, T2> a) =>
            v => b(a(v));

        /// <summary>
        /// Function composition
        /// </summary>
        /// <returns>() => b(a())</returns>
        [Pure]
        public static Func<T2> Compose<T1, T2>(this Func<T1, T2> b, Func<T1> a) =>
            () => b(a());

        /// <summary>
        /// Function composition
        /// </summary>
        /// <returns>v => b(a(v))</returns>
        [Pure]
        public static Func<T1, Unit> Compose<T1, T2>(this Action<T2> b, Func<T1, T2> a)
            => v => { b(a(v)); return Unit.Default; };

        /// <summary>
        /// Function composition
        /// </summary>
        /// <returns>() => b(a())</returns>
        [Pure]
        public static Func<Unit> Compose<T>(this Action<T> b, Func<T> a)
            => () => { b(a()); return Unit.Default; };

        /// <summary>
        /// Function back composition
        /// </summary>
        /// <returns>b(a(v))</returns>
        [Pure]
        public static Func<T1, T3> BackCompose<T1, T2, T3>(this Func<T1, T2> a, Func<T2, T3> b) =>
            v => b(a(v));

        /// <summary>
        /// Function back composition
        /// </summary>
        /// <returns>b(a())</returns>
        [Pure]
        public static Func<T2> BackCompose<T1, T2>(this Func<T1> a, Func<T1, T2> b) =>
            () => b(a());

        /// <summary>
        /// Function back composition
        /// </summary>
        /// <returns>v => b(a(v))</returns>
        [Pure]
        public static Func<T1, Unit> BackCompose<T1, T2>(this Func<T1, T2> a, Action<T2> b)
            => v => { b(a(v)); return Unit.Default; };

        /// <summary>
        /// Function back composition
        /// </summary>
        /// <returns>() => b(a())</returns>
        [Pure]
        public static Func<Unit> BackCompose<T>(this Func<T> a, Action<T> b)
            => () => { b(a()); return Unit.Default; };
    }
}
