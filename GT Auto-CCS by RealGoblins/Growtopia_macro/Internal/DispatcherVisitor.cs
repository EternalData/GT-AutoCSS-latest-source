using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000055 RID: 85
	public class DispatcherVisitor
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x00010EB8 File Offset: 0x0000F0B8
		public DispatcherVisitor()
		{
			Class21.smethod_0();
			this._ParamsVisitor = new List<string>();
			this.tagVisitor = new List<int>();
			this._CodeVisitor = TypeDescriptor.GetConverter(typeof(Keys));
			this.m_ConfigVisitor = new StringBuilder();
			base..ctor();
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00010F08 File Offset: 0x0000F108
		public void ExcludeMethod(IntPtr value, string cfg)
		{
			Console.WriteLine(cfg);
			cfg = cfg.ToUpper();
			ParamVisitor.PostMessage(value, 256U, (IntPtr)13, IntPtr.Zero);
			ParamVisitor.PostMessage(value, 257U, (IntPtr)13, IntPtr.Zero);
			int i = 0;
			while (i < cfg.Length)
			{
				string text = cfg[i].ToString();
				if (text == null)
				{
					goto IL_5C2;
				}
				uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
				Keys value2;
				if (num <= 772578730U)
				{
					if (num <= 621580159U)
					{
						if (num <= 554469683U)
						{
							if (num <= 252472541U)
							{
								if (num != 202139684U)
								{
									if (num != 252472541U)
									{
										goto IL_5C2;
									}
									if (!(text == "\n"))
									{
										goto IL_5C2;
									}
								}
								else if (!(text == "\t"))
								{
									goto IL_5C2;
								}
								value2 = Keys.Space;
							}
							else if (num != 537692064U)
							{
								if (num != 554469683U)
								{
									goto IL_5C2;
								}
								if (!(text == "$"))
								{
									goto IL_5C2;
								}
								value2 = Keys.Home;
							}
							else
							{
								if (!(text == "%"))
								{
									goto IL_5C2;
								}
								value2 = Keys.Left;
							}
						}
						else if (num <= 588024921U)
						{
							if (num != 571247302U)
							{
								if (num != 588024921U)
								{
									goto IL_5C2;
								}
								if (!(text == "&"))
								{
									goto IL_5C2;
								}
								value2 = Keys.Up;
							}
							else
							{
								if (!(text == "'"))
								{
									goto IL_5C2;
								}
								value2 = Keys.Right;
							}
						}
						else if (num != 604802540U)
						{
							if (num != 621580159U)
							{
								goto IL_5C2;
							}
							if (!(text == " "))
							{
								goto IL_5C2;
							}
							value2 = Keys.Space;
						}
						else
						{
							if (!(text == "!"))
							{
								goto IL_5C2;
							}
							value2 = Keys.Prior;
						}
					}
					else if (num <= 688690635U)
					{
						if (num <= 655135397U)
						{
							if (num != 638357778U)
							{
								if (num != 655135397U)
								{
									goto IL_5C2;
								}
								if (!(text == "\""))
								{
									goto IL_5C2;
								}
								value2 = Keys.Next;
							}
							else
							{
								if (!(text == "#"))
								{
									goto IL_5C2;
								}
								value2 = Keys.End;
							}
						}
						else if (num != 671913016U)
						{
							if (num != 688690635U)
							{
								goto IL_5C2;
							}
							if (!(text == ","))
							{
								goto IL_5C2;
							}
							value2 = Keys.Snapshot;
						}
						else
						{
							if (!(text == "-"))
							{
								goto IL_5C2;
							}
							value2 = Keys.Insert;
						}
					}
					else if (num <= 722245873U)
					{
						if (num != 705468254U)
						{
							if (num != 722245873U)
							{
								goto IL_5C2;
							}
							if (!(text == Class18.smethod_11(5114)))
							{
								goto IL_5C2;
							}
							value2 = Keys.Delete;
						}
						else
						{
							if (!(text == Class18.smethod_11(5192)))
							{
								goto IL_5C2;
							}
							value2 = Keys.OemQuestion;
						}
					}
					else if (num != 739023492U)
					{
						if (num != 755801111U)
						{
							if (num != 772578730U)
							{
								goto IL_5C2;
							}
							if (!(text == "+"))
							{
								goto IL_5C2;
							}
							value2 = Keys.Execute;
						}
						else
						{
							if (!(text == "("))
							{
								goto IL_5C2;
							}
							value2 = Keys.Down;
						}
					}
					else
					{
						if (!(text == ")"))
						{
							goto IL_5C2;
						}
						value2 = Keys.Select;
					}
				}
				else if (num <= 3305896031U)
				{
					if (num <= 973910158U)
					{
						if (num <= 940354920U)
						{
							if (num != 789356349U)
							{
								if (num != 940354920U)
								{
									goto IL_5C2;
								}
								if (!(text == "="))
								{
									goto IL_5C2;
								}
								value2 = (Keys.LButton | Keys.MButton | Keys.Back | Keys.ShiftKey | Keys.Space);
							}
							else
							{
								if (!(text == "*"))
								{
									goto IL_5C2;
								}
								value2 = Keys.Print;
							}
						}
						else if (num != 957132539U)
						{
							if (num != 973910158U)
							{
								goto IL_5C2;
							}
							if (!(text == "?"))
							{
								goto IL_5C2;
							}
							value2 = (Keys.LButton | Keys.RButton | Keys.MButton | Keys.Back | Keys.ShiftKey | Keys.Space);
						}
						else
						{
							if (!(text == "<"))
							{
								goto IL_5C2;
							}
							value2 = (Keys.MButton | Keys.Back | Keys.ShiftKey | Keys.Space);
						}
					}
					else if (num <= 1041020634U)
					{
						if (num != 990687777U)
						{
							if (num != 1041020634U)
							{
								goto IL_5C2;
							}
							if (!(text == ";"))
							{
								goto IL_5C2;
							}
							value2 = (Keys.LButton | Keys.RButton | Keys.Back | Keys.ShiftKey | Keys.Space);
						}
						else
						{
							if (!(text == ">"))
							{
								goto IL_5C2;
							}
							value2 = (Keys.RButton | Keys.MButton | Keys.Back | Keys.ShiftKey | Keys.Space);
						}
					}
					else if (num != 1057798253U)
					{
						if (num != 3289118412U)
						{
							if (num != 3305896031U)
							{
								goto IL_5C2;
							}
							if (!(text == "@"))
							{
								goto IL_5C2;
							}
							value2 = (Keys)64;
						}
						else
						{
							if (!(text == "A"))
							{
								goto IL_5C2;
							}
							value2 = Keys.LControlKey;
						}
					}
					else
					{
						if (!(text == ":"))
						{
							goto IL_5C2;
						}
						value2 = (Keys.RButton | Keys.Back | Keys.ShiftKey | Keys.Space);
					}
				}
				else if (num <= 3725336506U)
				{
					if (num <= 3641448411U)
					{
						if (num != 3624670792U)
						{
							if (num != 3641448411U)
							{
								goto IL_5C2;
							}
							if (!(text == Class18.smethod_11(5198)))
							{
								goto IL_5C2;
							}
							value2 = Keys.OemPipe;
						}
						else
						{
							if (!(text == "]"))
							{
								goto IL_5C2;
							}
							value2 = Keys.OemCloseBrackets;
						}
					}
					else if (num != 3658226030U)
					{
						if (num != 3725336506U)
						{
							goto IL_5C2;
						}
						if (!(text == "["))
						{
							goto IL_5C2;
						}
						value2 = Keys.OemOpenBrackets;
					}
					else
					{
						if (!(text == "_"))
						{
							goto IL_5C2;
						}
						value2 = Keys.Sleep;
					}
				}
				else if (num <= 4161554600U)
				{
					if (num != 3842779839U)
					{
						if (num != 4161554600U)
						{
							goto IL_5C2;
						}
						if (!(text == "}"))
						{
							goto IL_5C2;
						}
						value2 = Keys.F14;
					}
					else
					{
						if (!(text == "`"))
						{
							goto IL_5C2;
						}
						value2 = Keys.Oemtilde;
					}
				}
				else if (num != 4178332219U)
				{
					if (num != 4211887457U)
					{
						if (num != 4262220314U)
						{
							goto IL_5C2;
						}
						if (!(text == "{"))
						{
							goto IL_5C2;
						}
						value2 = Keys.F12;
					}
					else
					{
						if (!(text == "~"))
						{
							goto IL_5C2;
						}
						value2 = Keys.F15;
					}
				}
				else
				{
					if (!(text == "|"))
					{
						goto IL_5C2;
					}
					value2 = Keys.F13;
				}
				IL_5ED:
				Console.WriteLine(value2.ToString());
				ParamVisitor.PostMessage(value, 256U, (IntPtr)((int)value2), IntPtr.Zero);
				ParamVisitor.PostMessage(value, 257U, (IntPtr)((int)value2), IntPtr.Zero);
				Thread.Sleep(20);
				i++;
				continue;
				IL_5C2:
				try
				{
					value2 = (Keys)this._CodeVisitor.ConvertFromString(cfg[i].ToString());
				}
				catch (Exception)
				{
					value2 = Keys.Down;
				}
				goto IL_5ED;
			}
			ParamVisitor.PostMessage(value, 256U, (IntPtr)13, IntPtr.Zero);
			ParamVisitor.PostMessage(value, 257U, (IntPtr)13, IntPtr.Zero);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00011594 File Offset: 0x0000F794
		public void FillMethod()
		{
			while (this._IssuerVisitor)
			{
				for (int i = 0; i < this._ParamsVisitor.Count; i++)
				{
					this.m_ConfigVisitor = new StringBuilder();
					this.m_ConfigVisitor.Append(this._ParamsVisitor[i]);
					if (this.m_PublisherVisitor)
					{
						if (this.m_PrinterVisitor >= 9)
						{
							this.m_PrinterVisitor = 0;
						}
						if (this.m_PrinterVisitor == 5)
						{
							this.m_PrinterVisitor++;
						}
						this.m_ConfigVisitor.Insert(0, "`" + this.m_PrinterVisitor.ToString());
						this.m_PrinterVisitor++;
					}
					foreach (int processId in this.tagVisitor)
					{
						IntPtr mainWindowHandle = Process.GetProcessById(processId).MainWindowHandle;
						this.ExcludeMethod(mainWindowHandle, this.m_ConfigVisitor.ToString());
					}
					if (this.m_AdvisorVisitor)
					{
						if (i == this._ParamsVisitor.Count - 1)
						{
							Thread.Sleep(this._UtilsVisitor);
						}
						else
						{
							Thread.Sleep(2000);
						}
					}
					else
					{
						Thread.Sleep(this._UtilsVisitor);
					}
				}
			}
		}

		// Token: 0x04000131 RID: 305
		public List<string> _ParamsVisitor;

		// Token: 0x04000132 RID: 306
		public int _UtilsVisitor;

		// Token: 0x04000133 RID: 307
		public List<int> tagVisitor;

		// Token: 0x04000134 RID: 308
		public bool m_PublisherVisitor;

		// Token: 0x04000135 RID: 309
		public bool m_AdvisorVisitor;

		// Token: 0x04000136 RID: 310
		public bool _IssuerVisitor;

		// Token: 0x04000137 RID: 311
		public TypeConverter _CodeVisitor;

		// Token: 0x04000138 RID: 312
		public StringBuilder m_ConfigVisitor;

		// Token: 0x04000139 RID: 313
		public int m_PrinterVisitor;
	}
}
