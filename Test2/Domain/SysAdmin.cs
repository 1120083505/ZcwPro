﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace ConnName
{
    /// <summary>管理员</summary>
    [Serializable]
    [DataObject]
    [Description("管理员")]
    [BindIndex("PK_SysAdmin", true, "ID")]
    [BindTable("Sys_Admin", Description = "管理员", ConnName = "ConnName", DbType = DatabaseType.SqlServer)]
    public partial class SysAdmin : ISysAdmin
    {
        #region 属性
        private String _ID;
        /// <summary></summary>
        [DisplayName("ID")]
        [Description("")]
        [DataObjectField(true, false, false, 50)]
        [BindColumn("ID", "", "nvarchar(50)")]
        public virtual String ID
        {
            get { return _ID; }
            set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } }
        }

        private String _LoginName;
        /// <summary>登录名称</summary>
        [DisplayName("登录名称")]
        [Description("登录名称")]
        [DataObjectField(false, false, false, 500)]
        [BindColumn("LoginName", "登录名称", "nvarchar(500)")]
        public virtual String LoginName
        {
            get { return _LoginName; }
            set { if (OnPropertyChanging(__.LoginName, value)) { _LoginName = value; OnPropertyChanged(__.LoginName); } }
        }

        private String _LoginPwd;
        /// <summary>密码</summary>
        [DisplayName("密码")]
        [Description("密码")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("LoginPwd", "密码", "nvarchar(50)")]
        public virtual String LoginPwd
        {
            get { return _LoginPwd; }
            set { if (OnPropertyChanging(__.LoginPwd, value)) { _LoginPwd = value; OnPropertyChanged(__.LoginPwd); } }
        }

        private String _RealName;
        /// <summary>真实姓名</summary>
        [DisplayName("真实姓名")]
        [Description("真实姓名")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("RealName", "真实姓名", "nvarchar(50)")]
        public virtual String RealName
        {
            get { return _RealName; }
            set { if (OnPropertyChanging(__.RealName, value)) { _RealName = value; OnPropertyChanged(__.RealName); } }
        }

        private Int32 _IsLogin;
        /// <summary>登陆状态</summary>
        [DisplayName("登陆状态")]
        [Description("登陆状态")]
        [DataObjectField(false, false, false, 10)]
        [BindColumn("IsLogin", "登陆状态", "int")]
        public virtual Int32 IsLogin
        {
            get { return _IsLogin; }
            set { if (OnPropertyChanging(__.IsLogin, value)) { _IsLogin = value; OnPropertyChanged(__.IsLogin); } }
        }

        private String _RoleId;
        /// <summary>角色名称</summary>
        [DisplayName("角色名称")]
        [Description("角色名称")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("RoleId", "角色名称", "nvarchar(50)")]
        public virtual String RoleId
        {
            get { return _RoleId; }
            set { if (OnPropertyChanging(__.RoleId, value)) { _RoleId = value; OnPropertyChanged(__.RoleId); } }
        }

        private String _Email;
        /// <summary>Email</summary>
        [DisplayName("Email")]
        [Description("Email")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("Email", "Email", "nvarchar(50)")]
        public virtual String Email
        {
            get { return _Email; }
            set { if (OnPropertyChanging(__.Email, value)) { _Email = value; OnPropertyChanged(__.Email); } }
        }

        private DateTime _PubDate;
        /// <summary></summary>
        [DisplayName("PubDate")]
        [Description("")]
        [DataObjectField(false, false, false, 3)]
        [BindColumn("PubDate", "", "datetime")]
        public virtual DateTime PubDate
        {
            get { return _PubDate; }
            set { if (OnPropertyChanging(__.PubDate, value)) { _PubDate = value; OnPropertyChanged(__.PubDate); } }
        }

        private Int32 _Ident;
        /// <summary>权限分配（0、按角色1、按人）</summary>
        [DisplayName("权限分配")]
        [Description("权限分配（0、按角色1、按人）")]
        [DataObjectField(false, false, false, 10)]
        [BindColumn("Ident", "权限分配（0、按角色1、按人）", "int")]
        public virtual Int32 Ident
        {
            get { return _Ident; }
            set { if (OnPropertyChanging(__.Ident, value)) { _Ident = value; OnPropertyChanged(__.Ident); } }
        }

        private Int32 _ErrorCount;
        /// <summary></summary>
        [DisplayName("ErrorCount")]
        [Description("")]
        [DataObjectField(false, false, false, 10)]
        [BindColumn("ErrorCount", "", "int")]
        public virtual Int32 ErrorCount
        {
            get { return _ErrorCount; }
            set { if (OnPropertyChanging(__.ErrorCount, value)) { _ErrorCount = value; OnPropertyChanged(__.ErrorCount); } }
        }

        private DateTime _Intime;
        /// <summary></summary>
        [DisplayName("Intime")]
        [Description("")]
        [DataObjectField(false, false, true, 3)]
        [BindColumn("Intime", "", "datetime")]
        public virtual DateTime Intime
        {
            get { return _Intime; }
            set { if (OnPropertyChanging(__.Intime, value)) { _Intime = value; OnPropertyChanged(__.Intime); } }
        }

        private String _Ip;
        /// <summary></summary>
        [DisplayName("Ip")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Ip", "", "nvarchar(50)")]
        public virtual String Ip
        {
            get { return _Ip; }
            set { if (OnPropertyChanging(__.Ip, value)) { _Ip = value; OnPropertyChanged(__.Ip); } }
        }

        private String _LimitLogin;
        /// <summary>限制登陆方式(0、同Ip限制1、错误次数)</summary>
        [DisplayName("限制登陆方式")]
        [Description("限制登陆方式(0、同Ip限制1、错误次数)")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("LimitLogin", "限制登陆方式(0、同Ip限制1、错误次数)", "nvarchar(50)")]
        public virtual String LimitLogin
        {
            get { return _LimitLogin; }
            set { if (OnPropertyChanging(__.LimitLogin, value)) { _LimitLogin = value; OnPropertyChanged(__.LimitLogin); } }
        }

        private DateTime _EditPubdate;
        /// <summary></summary>
        [DisplayName("EditPubdate")]
        [Description("")]
        [DataObjectField(false, false, true, 3)]
        [BindColumn("EditPubdate", "", "datetime")]
        public virtual DateTime EditPubdate
        {
            get { return _EditPubdate; }
            set { if (OnPropertyChanging(__.EditPubdate, value)) { _EditPubdate = value; OnPropertyChanged(__.EditPubdate); } }
        }

        private String _EditAdminId;
        /// <summary></summary>
        [DisplayName("EditAdminId")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("EditAdminId", "", "nvarchar(50)")]
        public virtual String EditAdminId
        {
            get { return _EditAdminId; }
            set { if (OnPropertyChanging(__.EditAdminId, value)) { _EditAdminId = value; OnPropertyChanged(__.EditAdminId); } }
        }

        private Int32 _PowerType;
        /// <summary></summary>
        [DisplayName("PowerType")]
        [Description("")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("PowerType", "", "int")]
        public virtual Int32 PowerType
        {
            get { return _PowerType; }
            set { if (OnPropertyChanging(__.PowerType, value)) { _PowerType = value; OnPropertyChanged(__.PowerType); } }
        }

        private String _Address;
        /// <summary>地址</summary>
        [DisplayName("地址")]
        [Description("地址")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("Address", "地址", "nvarchar(200)")]
        public virtual String Address
        {
            get { return _Address; }
            set { if (OnPropertyChanging(__.Address, value)) { _Address = value; OnPropertyChanged(__.Address); } }
        }

        private String _Phone;
        /// <summary>联系电话</summary>
        [DisplayName("联系电话")]
        [Description("联系电话")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Phone", "联系电话", "nvarchar(50)")]
        public virtual String Phone
        {
            get { return _Phone; }
            set { if (OnPropertyChanging(__.Phone, value)) { _Phone = value; OnPropertyChanged(__.Phone); } }
        }

        private String _BankAccount;
        /// <summary></summary>
        [DisplayName("BankAccount")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("BankAccount", "", "nvarchar(50)")]
        public virtual String BankAccount
        {
            get { return _BankAccount; }
            set { if (OnPropertyChanging(__.BankAccount, value)) { _BankAccount = value; OnPropertyChanged(__.BankAccount); } }
        }
        #endregion

        #region 获取/设置 字段值
        /// <summary>
        /// 获取/设置 字段值。
        /// 一个索引，基类使用反射实现。
        /// 派生实体类可重写该索引，以避免反射带来的性能损耗
        /// </summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.ID : return _ID;
                    case __.LoginName : return _LoginName;
                    case __.LoginPwd : return _LoginPwd;
                    case __.RealName : return _RealName;
                    case __.IsLogin : return _IsLogin;
                    case __.RoleId : return _RoleId;
                    case __.Email : return _Email;
                    case __.PubDate : return _PubDate;
                    case __.Ident : return _Ident;
                    case __.ErrorCount : return _ErrorCount;
                    case __.Intime : return _Intime;
                    case __.Ip : return _Ip;
                    case __.LimitLogin : return _LimitLogin;
                    case __.EditPubdate : return _EditPubdate;
                    case __.EditAdminId : return _EditAdminId;
                    case __.PowerType : return _PowerType;
                    case __.Address : return _Address;
                    case __.Phone : return _Phone;
                    case __.BankAccount : return _BankAccount;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToString(value); break;
                    case __.LoginName : _LoginName = Convert.ToString(value); break;
                    case __.LoginPwd : _LoginPwd = Convert.ToString(value); break;
                    case __.RealName : _RealName = Convert.ToString(value); break;
                    case __.IsLogin : _IsLogin = Convert.ToInt32(value); break;
                    case __.RoleId : _RoleId = Convert.ToString(value); break;
                    case __.Email : _Email = Convert.ToString(value); break;
                    case __.PubDate : _PubDate = Convert.ToDateTime(value); break;
                    case __.Ident : _Ident = Convert.ToInt32(value); break;
                    case __.ErrorCount : _ErrorCount = Convert.ToInt32(value); break;
                    case __.Intime : _Intime = Convert.ToDateTime(value); break;
                    case __.Ip : _Ip = Convert.ToString(value); break;
                    case __.LimitLogin : _LimitLogin = Convert.ToString(value); break;
                    case __.EditPubdate : _EditPubdate = Convert.ToDateTime(value); break;
                    case __.EditAdminId : _EditAdminId = Convert.ToString(value); break;
                    case __.PowerType : _PowerType = Convert.ToInt32(value); break;
                    case __.Address : _Address = Convert.ToString(value); break;
                    case __.Phone : _Phone = Convert.ToString(value); break;
                    case __.BankAccount : _BankAccount = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得管理员字段信息的快捷方式</summary>
        public partial class _
        {
            ///<summary></summary>
            public static readonly Field ID = FindByName(__.ID);

            ///<summary>登录名称</summary>
            public static readonly Field LoginName = FindByName(__.LoginName);

            ///<summary>密码</summary>
            public static readonly Field LoginPwd = FindByName(__.LoginPwd);

            ///<summary>真实姓名</summary>
            public static readonly Field RealName = FindByName(__.RealName);

            ///<summary>登陆状态</summary>
            public static readonly Field IsLogin = FindByName(__.IsLogin);

            ///<summary>角色名称</summary>
            public static readonly Field RoleId = FindByName(__.RoleId);

            ///<summary>Email</summary>
            public static readonly Field Email = FindByName(__.Email);

            ///<summary></summary>
            public static readonly Field PubDate = FindByName(__.PubDate);

            ///<summary>权限分配（0、按角色1、按人）</summary>
            public static readonly Field Ident = FindByName(__.Ident);

            ///<summary></summary>
            public static readonly Field ErrorCount = FindByName(__.ErrorCount);

            ///<summary></summary>
            public static readonly Field Intime = FindByName(__.Intime);

            ///<summary></summary>
            public static readonly Field Ip = FindByName(__.Ip);

            ///<summary>限制登陆方式(0、同Ip限制1、错误次数)</summary>
            public static readonly Field LimitLogin = FindByName(__.LimitLogin);

            ///<summary></summary>
            public static readonly Field EditPubdate = FindByName(__.EditPubdate);

            ///<summary></summary>
            public static readonly Field EditAdminId = FindByName(__.EditAdminId);

            ///<summary></summary>
            public static readonly Field PowerType = FindByName(__.PowerType);

            ///<summary>地址</summary>
            public static readonly Field Address = FindByName(__.Address);

            ///<summary>联系电话</summary>
            public static readonly Field Phone = FindByName(__.Phone);

            ///<summary></summary>
            public static readonly Field BankAccount = FindByName(__.BankAccount);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得管理员字段名称的快捷方式</summary>
        partial class __
        {
            ///<summary></summary>
            public const String ID = "ID";

            ///<summary>登录名称</summary>
            public const String LoginName = "LoginName";

            ///<summary>密码</summary>
            public const String LoginPwd = "LoginPwd";

            ///<summary>真实姓名</summary>
            public const String RealName = "RealName";

            ///<summary>登陆状态</summary>
            public const String IsLogin = "IsLogin";

            ///<summary>角色名称</summary>
            public const String RoleId = "RoleId";

            ///<summary>Email</summary>
            public const String Email = "Email";

            ///<summary></summary>
            public const String PubDate = "PubDate";

            ///<summary>权限分配（0、按角色1、按人）</summary>
            public const String Ident = "Ident";

            ///<summary></summary>
            public const String ErrorCount = "ErrorCount";

            ///<summary></summary>
            public const String Intime = "Intime";

            ///<summary></summary>
            public const String Ip = "Ip";

            ///<summary>限制登陆方式(0、同Ip限制1、错误次数)</summary>
            public const String LimitLogin = "LimitLogin";

            ///<summary></summary>
            public const String EditPubdate = "EditPubdate";

            ///<summary></summary>
            public const String EditAdminId = "EditAdminId";

            ///<summary></summary>
            public const String PowerType = "PowerType";

            ///<summary>地址</summary>
            public const String Address = "Address";

            ///<summary>联系电话</summary>
            public const String Phone = "Phone";

            ///<summary></summary>
            public const String BankAccount = "BankAccount";

        }
        #endregion
    }

    /// <summary>管理员接口</summary>
    public partial interface ISysAdmin
    {
        #region 属性
        /// <summary></summary>
        String ID { get; set; }

        /// <summary>登录名称</summary>
        String LoginName { get; set; }

        /// <summary>密码</summary>
        String LoginPwd { get; set; }

        /// <summary>真实姓名</summary>
        String RealName { get; set; }

        /// <summary>登陆状态</summary>
        Int32 IsLogin { get; set; }

        /// <summary>角色名称</summary>
        String RoleId { get; set; }

        /// <summary>Email</summary>
        String Email { get; set; }

        /// <summary></summary>
        DateTime PubDate { get; set; }

        /// <summary>权限分配（0、按角色1、按人）</summary>
        Int32 Ident { get; set; }

        /// <summary></summary>
        Int32 ErrorCount { get; set; }

        /// <summary></summary>
        DateTime Intime { get; set; }

        /// <summary></summary>
        String Ip { get; set; }

        /// <summary>限制登陆方式(0、同Ip限制1、错误次数)</summary>
        String LimitLogin { get; set; }

        /// <summary></summary>
        DateTime EditPubdate { get; set; }

        /// <summary></summary>
        String EditAdminId { get; set; }

        /// <summary></summary>
        Int32 PowerType { get; set; }

        /// <summary>地址</summary>
        String Address { get; set; }

        /// <summary>联系电话</summary>
        String Phone { get; set; }

        /// <summary></summary>
        String BankAccount { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}