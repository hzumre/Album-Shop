﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani.Core.Interface
{
    public interface IEntity<T>
    {
        public T ID { get; set; }
    }
}
