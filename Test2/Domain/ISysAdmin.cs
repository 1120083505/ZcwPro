﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ConnName
{
	/// <summary>管理员接口</summary>
	public interface ISysAdmin
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