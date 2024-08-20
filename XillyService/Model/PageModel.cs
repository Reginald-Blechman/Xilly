using System;

namespace Page_Navigation_App.Model
{
	// Token: 0x02000013 RID: 19
	public class PageModel
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000099A6 File Offset: 0x00007BA6
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000099AE File Offset: 0x00007BAE
		public int CustomerCount { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000099B7 File Offset: 0x00007BB7
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000099BF File Offset: 0x00007BBF
		public string ProductStatus { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000099C8 File Offset: 0x00007BC8
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000099D0 File Offset: 0x00007BD0
		public DateOnly OrderDate { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000099D9 File Offset: 0x00007BD9
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000099E1 File Offset: 0x00007BE1
		public decimal TransactionValue { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000099EA File Offset: 0x00007BEA
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000099F2 File Offset: 0x00007BF2
		public TimeOnly ShipmentDelivery { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000099FB File Offset: 0x00007BFB
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00009A03 File Offset: 0x00007C03
		public bool LocationStatus { get; set; }
	}
}
