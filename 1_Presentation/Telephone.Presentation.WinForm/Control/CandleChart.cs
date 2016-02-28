using Ore.Infrastructure.MarketData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone.Presentation.WinForm.Control
{
    public class CandleChart
    {
        public static void SetPicboxChart(PictureBox box, List<IStockKLine> mktEquds, List<IStockKLine> mktEqudsEx)
        {
            //画图区域设置
            int regionWidth = box.Size.Width; //设置画图区域宽度
            int regionHeight = box.Size.Height; //设置画图区域高度
            int leftAndBottomPx = 40; //设置左边和下底空白像宽度素
            int rightAndTopPx = 20; //设置右边和上底空白像素宽度
            int middleBlankWidth = 30; //设置中间Price和Volumn图中间间距宽度
            int characterBlank = 8; //图上显示字的预留空白宽度

            box.BackColor = Color.Black;
            Bitmap bmap = new Bitmap(regionWidth, regionHeight);
            Graphics gph = Graphics.FromImage(bmap);
            gph.Clear(Color.Black);

            //画矩形框图
            Pen penLine = new Pen(Color.Gray);
            penLine.Width = 1;
            gph.DrawRectangle(penLine, leftAndBottomPx, rightAndTopPx, regionWidth - leftAndBottomPx - rightAndTopPx, regionHeight - leftAndBottomPx - rightAndTopPx);

            //设置Volumn图高度
            int volRegionHeight = (regionHeight - leftAndBottomPx - rightAndTopPx) / 4;
            gph.DrawLine(penLine, leftAndBottomPx, regionHeight - leftAndBottomPx - volRegionHeight, regionWidth - rightAndTopPx, regionHeight - leftAndBottomPx - volRegionHeight); //绘制Volumn上底线
            gph.DrawLine(penLine, leftAndBottomPx, regionHeight - leftAndBottomPx - volRegionHeight / 2, regionWidth - rightAndTopPx, regionHeight - leftAndBottomPx - volRegionHeight / 2); //绘制Volumn中间线
            //设置Price图高度
            int priceRegionHeight = regionHeight - leftAndBottomPx - rightAndTopPx - volRegionHeight - middleBlankWidth;
            gph.DrawLine(penLine, leftAndBottomPx, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth, regionWidth - rightAndTopPx, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth); //绘制Pirice底线
            gph.DrawLine(penLine, leftAndBottomPx, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - priceRegionHeight / 4, regionWidth - rightAndTopPx, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - priceRegionHeight / 4); //绘制Pirice线1
            gph.DrawLine(penLine, leftAndBottomPx, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - priceRegionHeight / 2, regionWidth - rightAndTopPx, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - priceRegionHeight / 2); //绘制Pirice线2
            gph.DrawLine(penLine, leftAndBottomPx, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - priceRegionHeight * 3 / 4, regionWidth - rightAndTopPx, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - priceRegionHeight * 3 / 4); //绘制Pirice线3

            //设置单个柱状图宽度
            int singleWidth = (regionWidth - leftAndBottomPx - rightAndTopPx) / mktEquds.Count();
            //获取Max Vlomun、Min Price、Max Price
            double maxVolumn = 0;
            double maxPrice = 0;
            double minPrice = 1000;
            foreach (IStockKLine equd in mktEquds)
            {
                if (maxVolumn < equd.Volume)
                    maxVolumn = equd.Volume;
                if (maxPrice < equd.High)
                    maxPrice = equd.High;
                if (minPrice > equd.Low)
                    minPrice = equd.Low;
            }

            //画单个Volumn柱状图
            int volIndex = 0;
            List<PointF> fiveEqualList = new List<PointF>();
            List<PointF> tenEqualList = new List<PointF>();
            foreach (IStockKLine equd in mktEquds)
            {
                #region Volumn

                double tempVol = equd.Volume;
                //高度计算
                int volHeight = (int)(tempVol * volRegionHeight / maxVolumn);
                PointF[] volPointF = new PointF[4] { new PointF(leftAndBottomPx + volIndex * singleWidth, regionHeight - leftAndBottomPx),
                    new PointF(leftAndBottomPx + volIndex * singleWidth, regionHeight - leftAndBottomPx - volHeight),
                    new PointF(leftAndBottomPx + (volIndex + 1) * singleWidth, regionHeight - leftAndBottomPx - volHeight),
                    new PointF(leftAndBottomPx + (volIndex + 1) * singleWidth, regionHeight - leftAndBottomPx)
                }; //Vol四边形
                if (equd.Close >= equd.Open)
                {
                    gph.FillPolygon(new SolidBrush(Color.Red), volPointF);
                    gph.DrawPolygon(Pens.Gray, volPointF);
                }
                else
                {
                    gph.FillPolygon(new SolidBrush(Color.Aqua), volPointF);
                    gph.DrawPolygon(Pens.Gray, volPointF);
                }

                #endregion

                #region Price

                //计算Max、Min、Close、Open相对于Price图的高度
                int tempHighestHeight = (int)((equd.High - minPrice) / (maxPrice - minPrice) * priceRegionHeight);
                int tempLowestHeight = (int)((equd.Low - minPrice) / (maxPrice - minPrice) * priceRegionHeight);
                int tempOpenHeight = (int)((equd.Open - minPrice) / (maxPrice - minPrice) * priceRegionHeight);
                int tempCloseHeight = (int)((equd.Close - minPrice) / (maxPrice - minPrice) * priceRegionHeight);
                //构造Price的Candle图
                PointF[] pricePointF = new PointF[4] { new PointF(leftAndBottomPx + volIndex * singleWidth, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - tempOpenHeight),
                    new PointF(leftAndBottomPx + volIndex * singleWidth, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - tempCloseHeight),
                    new PointF(leftAndBottomPx + (volIndex + 1) * singleWidth, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - tempCloseHeight),
                    new PointF(leftAndBottomPx + (volIndex + 1) * singleWidth, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - tempOpenHeight)}; //Price四边形
                if (equd.Close >= equd.Open)
                {
                    gph.FillPolygon(new SolidBrush(Color.Red), pricePointF);
                    Pen penRed = new Pen(Color.Red, 2);
                    gph.DrawLine(penRed, leftAndBottomPx + (int)((volIndex + 0.5) * singleWidth), regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - tempLowestHeight, leftAndBottomPx + (int)((volIndex + 0.5) * singleWidth), regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - tempHighestHeight); //绘制Price最高最低线
                }
                else
                {
                    gph.FillPolygon(new SolidBrush(Color.Aqua), pricePointF);
                    Pen penAqua = new Pen(Color.Aqua, 2);
                    gph.DrawLine(penAqua, leftAndBottomPx + (int)((volIndex + 0.5) * singleWidth), regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - tempLowestHeight, leftAndBottomPx + (int)((volIndex + 0.5) * singleWidth), regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - tempHighestHeight); //绘制Price最高最低线
                }

                #endregion

                #region 画均线

                //5日均线
                double? fivePriceValue = GetEqualPrice(mktEqudsEx, equd.Time, 5);
                if (fivePriceValue != null)
                {
                    int tempFiveHeight = (int)((fivePriceValue.Value - minPrice) / (maxPrice - minPrice) * priceRegionHeight);
                    PointF fivePointF = new PointF(leftAndBottomPx + (int)((volIndex + 0.5) * singleWidth), regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - tempFiveHeight);
                    fiveEqualList.Add(fivePointF);
                }
                //10日均线
                double? tenPriceValue = GetEqualPrice(mktEqudsEx, equd.Time, 10);
                if (tenPriceValue != null)
                {
                    int tempTenHeight = (int)((tenPriceValue.Value - minPrice) / (maxPrice - minPrice) * priceRegionHeight);
                    PointF tenPointF = new PointF(leftAndBottomPx + (int)((volIndex + 0.5) * singleWidth), regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - tempTenHeight);
                    tenEqualList.Add(tenPointF);
                }

                #endregion                

                volIndex++;
            }

            //添加Volumn描述
            gph.DrawString(mktEquds[0].Time.ToString("yyyy-MM-dd"), new Font("宋体", 10), Brushes.White, new PointF(characterBlank, regionHeight - leftAndBottomPx + characterBlank));
            gph.DrawString(mktEquds[mktEquds.Count() - 1].Time.ToString("yyyy-MM-dd"), new Font("宋体", 10), Brushes.White, new PointF(regionWidth - rightAndTopPx - 70, regionHeight - leftAndBottomPx + characterBlank));
            gph.DrawString("当日成交量: " + (mktEquds[mktEquds.Count() - 1].Volume * 100), new Font("宋体", 10), Brushes.White, new PointF(leftAndBottomPx + 4, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth + 8));
            //添加Price价格区间数字
            gph.DrawString(minPrice.ToString(".00"), new Font("宋体", 9), Brushes.White, 4, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - priceRegionHeight * 0 / 4 - 5);  //最低线
            gph.DrawString((minPrice + (maxPrice - minPrice) * 1 / 4).ToString(".00"), new Font("宋体", 9), Brushes.White, 4, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - priceRegionHeight * 1 / 4 - 5);  //最低线
            gph.DrawString((minPrice + (maxPrice - minPrice) * 2 / 4).ToString(".00"), new Font("宋体", 9), Brushes.White, 4, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - priceRegionHeight * 2 / 4 - 5);  //最低线
            gph.DrawString((minPrice + (maxPrice - minPrice) * 3 / 4).ToString(".00"), new Font("宋体", 9), Brushes.White, 4, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - priceRegionHeight * 3 / 4 - 5);  //最低线
            gph.DrawString(maxPrice.ToString(".00"), new Font("宋体", 9), Brushes.White, 4, regionHeight - leftAndBottomPx - volRegionHeight - middleBlankWidth - priceRegionHeight * 4 / 4 - 5);  //最低线
            //添加日均线
            for (int m = 1; m < tenEqualList.Count; m++)
            {
                Pen penYellow = new Pen(Color.Yellow, 1.6f);
                gph.DrawLine(penYellow, tenEqualList[m - 1], tenEqualList[m]); //绘制10日均线
            }
            //添加日均线
            for (int m = 1; m < fiveEqualList.Count; m++)
            {
                Pen penWhite = new Pen(Color.White, 1.6f);
                gph.DrawLine(penWhite, fiveEqualList[m - 1], fiveEqualList[m]); //绘制5日均线
            }

            box.Image = bmap;
        }

        /// <summary>
        /// 获取含date的5日均价，这里需要判断是否够5日的条件
        /// </summary>
        /// <returns></returns>
        private static double? GetEqualPrice(List<IStockKLine> mktEquds, DateTime date, int day)
        {
            int index = 0;
            double totalPrice = 0;
            for (int i = mktEquds.Count() - 1; i >= 0; i--)
            {
                IStockKLine tempEqud = mktEquds[i];
                if (tempEqud.Time <= date)
                {
                    totalPrice += tempEqud.Close;
                    if (++index >= day) break;
                }
            }
            if (index == day)
            {
                return totalPrice / day;
            }
            else
            {
                return null;
            }
        }

        public static void SetPicboxChart(PictureBox box, List<IParticipation> orgPercents)
        {
            //画图区域设置
            int regionWidth = box.Size.Width; //设置画图区域宽度
            int regionHeight = box.Size.Height; //设置画图区域高度
            int leftAndBottomPx = 40; //设置左边和下底空白像宽度素
            int rightAndTopPx = 20; //设置右边和上底空白像素宽度
            int middleBlankWidth = 30; //设置中间Price和Volumn图中间间距宽度

            box.BackColor = Color.Black;
            Bitmap bmap = new Bitmap(regionWidth, regionHeight);
            Graphics gph = Graphics.FromImage(bmap);
            gph.Clear(Color.Black);

            //画矩形框图
            Pen penLine = new Pen(Color.Gray);
            penLine.Width = 1;
            gph.DrawRectangle(penLine, leftAndBottomPx, rightAndTopPx, regionWidth - leftAndBottomPx - rightAndTopPx, regionHeight - leftAndBottomPx - rightAndTopPx);

            //设置capital图高度
            int volcapitalHeight = (regionHeight - leftAndBottomPx - rightAndTopPx) / 4;
            gph.DrawLine(penLine, leftAndBottomPx, regionHeight - leftAndBottomPx - volcapitalHeight, regionWidth - rightAndTopPx, regionHeight - leftAndBottomPx - volcapitalHeight); //绘制capital上底线
            gph.DrawLine(penLine, leftAndBottomPx, regionHeight - leftAndBottomPx - volcapitalHeight / 2, regionWidth - rightAndTopPx, regionHeight - leftAndBottomPx - volcapitalHeight / 2); //绘制capital中间线
            //设置Org图高度
            int orgRegionHeight = regionHeight - leftAndBottomPx - rightAndTopPx - volcapitalHeight - middleBlankWidth;
            gph.DrawLine(penLine, leftAndBottomPx, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth, regionWidth - rightAndTopPx, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth); //绘制Org线1
            gph.DrawLine(penLine, leftAndBottomPx, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - orgRegionHeight / 4, regionWidth - rightAndTopPx, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - orgRegionHeight / 4); //绘制Org线1
            gph.DrawLine(penLine, leftAndBottomPx, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - orgRegionHeight / 2, regionWidth - rightAndTopPx, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - orgRegionHeight / 2); //绘制Org线2
            gph.DrawLine(penLine, leftAndBottomPx, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - orgRegionHeight * 3 / 4, regionWidth - rightAndTopPx, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - orgRegionHeight * 3 / 4); //绘制Org线3

            double maxOrg = 0;
            double minOrg = 100;
            double maxCapital = 0;
            foreach (IParticipation org in orgPercents)
            {
                if (maxOrg < org.Value) maxOrg = org.Value;
                if (minOrg > org.Value) minOrg = org.Value;

                if (maxCapital < Math.Abs(org.MainForceInflows)) maxCapital = Math.Abs(org.MainForceInflows);
            }
            //最大值和最小值的差值必须大于20
            double diffConstValue = 20.0;
            double maxValue = maxOrg;
            double minValue = minOrg;
            if (maxOrg - minOrg < diffConstValue)
            {
                double middleValue = (maxOrg + minOrg) / 2;
                maxValue = middleValue + diffConstValue / 2;
                minValue = middleValue - diffConstValue / 2;
            }
            //设置单个柱状图宽度
            int singleWidth = (regionWidth - leftAndBottomPx - rightAndTopPx) / orgPercents.Count;
            //绘制Org个点图
            int vorgIndex = 0;
            List<PointF> orgPointList = new List<PointF>();
            foreach (IParticipation org in orgPercents)
            {
                #region Capital

                double tempCapital = org.MainForceInflows;
                //高度计算
                int capitalHeight = (int)(tempCapital * volcapitalHeight / maxCapital / 2);
                PointF[] volPointF = new PointF[4] { new PointF(leftAndBottomPx + vorgIndex * singleWidth, regionHeight - leftAndBottomPx - volcapitalHeight / 2),
                        new PointF(leftAndBottomPx + vorgIndex * singleWidth, regionHeight - leftAndBottomPx - volcapitalHeight / 2 - capitalHeight),
                        new PointF(leftAndBottomPx + (vorgIndex + 1) * singleWidth, regionHeight - leftAndBottomPx - volcapitalHeight / 2 - capitalHeight),
                        new PointF(leftAndBottomPx + (vorgIndex + 1) * singleWidth, regionHeight - leftAndBottomPx - volcapitalHeight / 2)
                    }; //Vol四边形
                if (tempCapital >= 0)
                {
                    gph.FillPolygon(new SolidBrush(Color.Red), volPointF);
                    gph.DrawPolygon(Pens.Gray, volPointF);
                }
                else
                {
                    gph.FillPolygon(new SolidBrush(Color.Aqua), volPointF);
                    gph.DrawPolygon(Pens.Gray, volPointF);
                }

                #endregion

                double orgValue = org.Value;
                int tempHeight = (int)((orgValue - minValue) / (maxValue - minValue) * orgRegionHeight);
                PointF orgPoint = new PointF(leftAndBottomPx + (int)((vorgIndex + 0.5) * singleWidth), regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - tempHeight);
                orgPointList.Add(orgPoint);
                //Pen penBlue = new Pen(Color.Red, 2);
                //gph.DrawEllipse(penBlue, leftAndBottomPx + (int)((vorgIndex + 0.5) * singleWidth), regionHeight - leftAndBottomPx - tempHeight, 4, 4);
                //gph.FillEllipse(new SolidBrush(Color.Red), leftAndBottomPx + (int)((vorgIndex + 0.5) * singleWidth), regionHeight - leftAndBottomPx - tempHeight, 4, 4);
                vorgIndex++;
            }
            //绘制Y轴数值
            double tempMiddleValue = (minValue + maxValue) / 2;
            gph.DrawString(minValue.ToString(".0") + "%", new Font("宋体", 9), Brushes.White, 4, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - orgRegionHeight * 0 / 4 - 5);  //最低线
            gph.DrawString(((minValue + tempMiddleValue) / 2).ToString(".0") + "%", new Font("宋体", 9), Brushes.White, 4, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - orgRegionHeight * 1 / 4 - 5);  //最低线
            gph.DrawString(tempMiddleValue.ToString(".0") + "%", new Font("宋体", 9), Brushes.White, 4, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - orgRegionHeight * 2 / 4 - 5);  //最低线
            gph.DrawString(((tempMiddleValue + maxValue) / 2).ToString(".0") + "%", new Font("宋体", 9), Brushes.White, 4, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - orgRegionHeight * 3 / 4 - 5);  //最低线
            gph.DrawString(maxValue.ToString(".0") + "%", new Font("宋体", 9), Brushes.White, 4, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - orgRegionHeight * 4 / 4 - 5);  //最低线
            //绘制连线
            for (int m = 1; m < orgPointList.Count; m++)
            {
                Pen penWhite = new Pen(Color.White, 1.6f);
                gph.DrawLine(penWhite, orgPointList[m - 1], orgPointList[m]); //绘制10日均线
            }
            //绘制X轴日期
            gph.DrawString(orgPercents[0].Time.ToString("yyyy-MM-dd"), new Font("宋体", 10), Brushes.White, new PointF(leftAndBottomPx, regionHeight - leftAndBottomPx + 8));
            gph.DrawString(orgPercents[orgPercents.Count - 1].Time.ToString("yyyy-MM-dd"), new Font("宋体", 10), Brushes.White, new PointF(regionWidth - rightAndTopPx - 70, regionHeight - leftAndBottomPx + 8));
            gph.DrawString("当日资金净流入: " + (orgPercents[orgPercents.Count - 1].MainForceInflows.ToString("0.00")) + "万", new Font("宋体", 10), Brushes.White, new PointF(leftAndBottomPx + 4, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth + 8));
            //最后绘制点
            vorgIndex = 0;
            foreach (IParticipation org in orgPercents)
            {
                double orgValue = org.Value;
                int tempHeight = (int)((orgValue - minValue) / (maxValue - minValue) * orgRegionHeight);
                Pen penBlue = new Pen(Color.Red, 2);
                gph.DrawEllipse(penBlue, leftAndBottomPx + (int)((vorgIndex + 0.5) * singleWidth) - 2, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - tempHeight - 2, 5, 5);
                gph.FillEllipse(new SolidBrush(Color.Red), leftAndBottomPx + (int)((vorgIndex + 0.5) * singleWidth) - 2, regionHeight - leftAndBottomPx - volcapitalHeight - middleBlankWidth - tempHeight - 2, 5, 5);
                vorgIndex++;
            }
            box.Image = bmap;
        }
    }
}
