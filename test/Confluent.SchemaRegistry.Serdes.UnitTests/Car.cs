﻿// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 1.0.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Confluent.Kafka.Examples.AvroSpecific
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using global::Avro;
    using global::Avro.Specific;

    public partial class Car : ISpecificRecord
    {
        public static Schema _SCHEMA = Schema.Parse("{\"type\":\"record\",\"name\":\"Car\",\"namespace\":\"Confluent.Kafka.Examples.AvroSpecific" +
                "\",\"fields\":[{\"name\":\"name\",\"type\":\"string\"},{\"name\":\"color\",\"type\":[\"string\",\"null\"]}]}");
        private string _name;
        private string _color;
        public virtual Schema Schema
        {
            get
            {
                return Car._SCHEMA;
            }
        }
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        public string color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }
        public virtual object Get(int fieldPos)
        {
            switch (fieldPos)
            {
                case 0: return this.name;
                case 1: return this.color;
                default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
            };
        }
        public virtual void Put(int fieldPos, object fieldValue)
        {
            switch (fieldPos)
            {
                case 0: this.name = (System.String)fieldValue; break;
                case 1: this.color = (System.String)fieldValue; break;
                default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
            };
        }
    }
}