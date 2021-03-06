﻿using System;
using System.Runtime.Serialization;

namespace FuzzyRanks.Matching.PhoneticKey.Base
{
    [Serializable]
    [DataContract]
    [KnownType(typeof(EditexKey))]
    [KnownType(typeof(Phonix))]
    [KnownType(typeof(SoundEx))]
    [KnownType(typeof(SimpleTextKey))]
    [KnownType(typeof(Metaphone))]
    [KnownType(typeof(DoubleMetaphone))]
    [KnownType(typeof(DaitchMokotoff))]
    public abstract class PhoneticKeyBuilder : IPhoneticKeyBuilder
    {
        // ***********************Fields***********************

        private int maxLength = 4;

        // ***********************Properties***********************

        [DataMember]
        public int MaxLength
        {
            get { return this.maxLength; }
            set { this.maxLength = value; }
        }

        public string Name
        {
            get { return this.GetType().Name; }
        }

        // ***********************Functions***********************

        public abstract string BuildKey(string str1);
    }
}