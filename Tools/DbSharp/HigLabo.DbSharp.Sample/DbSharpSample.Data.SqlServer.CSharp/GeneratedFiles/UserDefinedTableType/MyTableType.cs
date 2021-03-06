﻿using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using HigLabo.DbSharp;

namespace HigLabo.DbSharpSample.SqlServer
{
    public partial class MyTableType : UserDefinedTableType<MyTableType.Record>
    {
        public override DataTable CreateDataTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("BigIntColumn", typeof(Int64));
            dt.Columns.Add("BinaryColumn", typeof(Byte[]));
            dt.Columns.Add("ImageColumn", typeof(Byte[]));
            dt.Columns.Add("VarBinaryColumn", typeof(Byte[]));
            dt.Columns.Add("BitColumn", typeof(Boolean));
            dt.Columns.Add("CharColumn", typeof(String));
            dt.Columns.Add("NCharColumn", typeof(String));
            dt.Columns.Add("NTextColumn", typeof(String));
            dt.Columns.Add("NVarCharColumn", typeof(String));
            dt.Columns.Add("TextColumn", typeof(String));
            dt.Columns.Add("VarCharColumn", typeof(String));
            dt.Columns.Add("XmlColumn", typeof(String));
            dt.Columns.Add("DateTimeColumn", typeof(DateTime));
            dt.Columns.Add("SmallDateTimeColumn", typeof(DateTime));
            dt.Columns.Add("DateColumn", typeof(DateTime));
            dt.Columns.Add("TimeColumn", typeof(TimeSpan));
            dt.Columns.Add("DateTime2Column", typeof(DateTime));
            dt.Columns.Add("DecimalColumn", typeof(Decimal));
            dt.Columns.Add("MoneyColumn", typeof(Decimal));
            dt.Columns.Add("SmallMoneyColumn", typeof(Decimal));
            dt.Columns.Add("FloatColumn", typeof(Double));
            dt.Columns.Add("IntColumn", typeof(Int32));
            dt.Columns.Add("RealColumn", typeof(Single));
            dt.Columns.Add("UniqueIdentifierColumn", typeof(Guid));
            dt.Columns.Add("SmallIntColumn", typeof(Int16));
            dt.Columns.Add("TinyIntColumn", typeof(Byte));
            dt.Columns.Add("DateTimeOffsetColumn", typeof(DateTimeOffset));
            dt.Columns.Add("EnumColumn", typeof(String));
            return dt;
        }

        public partial class Record : UserDefinedTableTypeRecord
        {
            private Int64 _BigIntColumn;
            private Byte[] _BinaryColumn;
            private Byte[] _ImageColumn;
            private Byte[] _VarBinaryColumn;
            private Boolean? _BitColumn;
            private String _CharColumn = "";
            private String _NCharColumn = "";
            private String _NTextColumn = "";
            private String _NVarCharColumn = "";
            private String _TextColumn = "";
            private String _VarCharColumn = "";
            private String _XmlColumn = "";
            private DateTime? _DateTimeColumn;
            private DateTime? _SmallDateTimeColumn;
            private DateTime? _DateColumn;
            private TimeSpan? _TimeColumn;
            private DateTime? _DateTime2Column;
            private Decimal? _DecimalColumn;
            private Decimal? _MoneyColumn;
            private Decimal? _SmallMoneyColumn;
            private Double? _FloatColumn;
            private Int32? _IntColumn;
            private Single? _RealColumn;
            private Guid? _UniqueIdentifierColumn;
            private Int16? _SmallIntColumn;
            private Byte? _TinyIntColumn;
            private DateTimeOffset? _DateTimeOffsetColumn;
            private MyEnum? _EnumColumn;

            public Int64 BigIntColumn
            {
                get
                {
                    return _BigIntColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _BigIntColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public Byte[] BinaryColumn
            {
                get
                {
                    return _BinaryColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _BinaryColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public Byte[] ImageColumn
            {
                get
                {
                    return _ImageColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _ImageColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public Byte[] VarBinaryColumn
            {
                get
                {
                    return _VarBinaryColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _VarBinaryColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public Boolean? BitColumn
            {
                get
                {
                    return _BitColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _BitColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public String CharColumn
            {
                get
                {
                    return _CharColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _CharColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public String NCharColumn
            {
                get
                {
                    return _NCharColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _NCharColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public String NTextColumn
            {
                get
                {
                    return _NTextColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _NTextColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public String NVarCharColumn
            {
                get
                {
                    return _NVarCharColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _NVarCharColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public String TextColumn
            {
                get
                {
                    return _TextColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _TextColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public String VarCharColumn
            {
                get
                {
                    return _VarCharColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _VarCharColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public String XmlColumn
            {
                get
                {
                    return _XmlColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _XmlColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public DateTime? DateTimeColumn
            {
                get
                {
                    return _DateTimeColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _DateTimeColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public DateTime? SmallDateTimeColumn
            {
                get
                {
                    return _SmallDateTimeColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _SmallDateTimeColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public DateTime? DateColumn
            {
                get
                {
                    return _DateColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _DateColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public TimeSpan? TimeColumn
            {
                get
                {
                    return _TimeColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _TimeColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public DateTime? DateTime2Column
            {
                get
                {
                    return _DateTime2Column;
                }
                set
                {
                    this.SetPropertyValue(ref _DateTime2Column, value, this.GetPropertyChangedEventHandler());
                }
            }
            public Decimal? DecimalColumn
            {
                get
                {
                    return _DecimalColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _DecimalColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public Decimal? MoneyColumn
            {
                get
                {
                    return _MoneyColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _MoneyColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public Decimal? SmallMoneyColumn
            {
                get
                {
                    return _SmallMoneyColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _SmallMoneyColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public Double? FloatColumn
            {
                get
                {
                    return _FloatColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _FloatColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public Int32? IntColumn
            {
                get
                {
                    return _IntColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _IntColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public Single? RealColumn
            {
                get
                {
                    return _RealColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _RealColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public Guid? UniqueIdentifierColumn
            {
                get
                {
                    return _UniqueIdentifierColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _UniqueIdentifierColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public Int16? SmallIntColumn
            {
                get
                {
                    return _SmallIntColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _SmallIntColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public Byte? TinyIntColumn
            {
                get
                {
                    return _TinyIntColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _TinyIntColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public DateTimeOffset? DateTimeOffsetColumn
            {
                get
                {
                    return _DateTimeOffsetColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _DateTimeOffsetColumn, value, this.GetPropertyChangedEventHandler());
                }
            }
            public MyEnum? EnumColumn
            {
                get
                {
                    return _EnumColumn;
                }
                set
                {
                    this.SetPropertyValue(ref _EnumColumn, value, this.GetPropertyChangedEventHandler());
                }
            }

            public Record()
            {
            }

            public override Object[] GetValues()
            {
                Object[] oo = new Object[28];
                oo[0] = this.BigIntColumn;
                oo[1] = this.BinaryColumn;
                oo[2] = this.ImageColumn;
                oo[3] = this.VarBinaryColumn;
                oo[4] = this.BitColumn;
                oo[5] = this.CharColumn;
                oo[6] = this.NCharColumn;
                oo[7] = this.NTextColumn;
                oo[8] = this.NVarCharColumn;
                oo[9] = this.TextColumn;
                oo[10] = this.VarCharColumn;
                oo[11] = this.XmlColumn;
                oo[12] = this.DateTimeColumn;
                oo[13] = this.SmallDateTimeColumn;
                oo[14] = this.DateColumn;
                oo[15] = this.TimeColumn;
                oo[16] = this.DateTime2Column;
                oo[17] = this.DecimalColumn;
                oo[18] = this.MoneyColumn;
                oo[19] = this.SmallMoneyColumn;
                oo[20] = this.FloatColumn;
                oo[21] = this.IntColumn;
                oo[22] = this.RealColumn;
                oo[23] = this.UniqueIdentifierColumn;
                oo[24] = this.SmallIntColumn;
                oo[25] = this.TinyIntColumn;
                oo[26] = this.DateTimeOffsetColumn;
                if (this.EnumColumn != null) oo[27] = this.EnumColumn.ToString();
                return oo;
            }
        }
    }
}
