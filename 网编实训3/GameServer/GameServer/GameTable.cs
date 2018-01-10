//-------------------GameTable.cs-----------------//
using System;
using System.Timers;
using System.Windows.Forms;
namespace GameServer
{
    class GameTable
    {
        private const int None = -1;       //������
        private const int Black = 0;       //��ɫ����
        private const int White = 1;       //��ɫ����
        public Player[] gamePlayer;        //����ͬһ���������Ϣ
        private int[,] grid = new int[15, 15];       //15*15�ķ���
        private int NextdotColor = 0;            //Ӧ�ò��������ӻ��ǰ�����
        private ListBox listbox;
        Service service;

        public GameTable(ListBox listbox)
        {
            gamePlayer = new Player[2];
            gamePlayer[0] = new Player();
            gamePlayer[1] = new Player();
            this.listbox = listbox;
            service = new Service(listbox);
            ResetGrid();
        }

        /// <summary>��������</summary>
        public void ResetGrid()
        {
            for (int i = 0; i <= grid.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= grid.GetUpperBound(1); j++)
                {
                    grid[i, j] = None;
                }
            }
        }

        /// <summary>���Ͳ�����������Ϣ</summary>
        /// <param name="i">ָ�����̵ĵڼ���</param>
        /// <param name="j">ָ�����̵ĵڼ���</param>
        /// <param name="dotColor">������ɫ</param>
        public void SetDot(int i, int j, int dotColor)
        {
            //�������û����Ͳ�����������Ϣ�����ж��Ƿ�����������
            //���͸�ʽ��SetDot,��,��,��ɫ
            grid[i, j] = dotColor;
            service.SendToBoth(this, string.Format("SetDot,{0},{1},{2}", i, j, dotColor));
            if (judgeWin() != -1)
            {
                ShowWin(judgeWin());
            }
        }

        private int judgeWin()
        {
            for (int i = 0; i <= grid.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= grid.GetUpperBound(1); j++)
                {
                    if (grid[i, j] != -1)
                    {
                        //��
                        for (int x = 1; x < 5 && x + i <= grid.GetUpperBound(0); x++)
                        {
                            if (grid[i + x, j] != grid[i, j])
                            {
                                break;
                            }
                            else
                            {
                                if (x == 4)
                                {
                                    return grid[i, j];
                                }
                            }
                        }
                        //��
                        for (int y = 1; y < 5 && y + j <= grid.GetUpperBound(1); y++)
                        {
                            if (grid[i, j + y] != grid[i, j])
                            {
                                break;
                            }
                            else
                            {
                                if (y == 4)
                                {
                                    return grid[i, j];
                                }

                            }
                        }
                        //����
                        for (int y = 1; y < 5 && y + i <= grid.GetUpperBound(0) && y + j <= grid.GetUpperBound(1); y++)
                        {

                            if (grid[i + y, j + y] != grid[i, j])
                            {
                                break;
                            }
                            else
                            {
                                if (y == 4)
                                {
                                    return grid[i, j];
                                }

                            }
                        }
                        //����
                        for (int y = 1; y < 5 && i - y > 0 && y + j <= grid.GetUpperBound(1); y++)
                        {

                            if (grid[i - y, j + y] != grid[i, j])
                            {
                                break;
                            }
                            else
                            {
                                if (y == 4)
                                {
                                    return grid[i, j];
                                }

                            }
                        }


                    }
                }
            }
            return None;
        }

        /// <summary>�������ڵ����ɫΪdotColor</summary>
        /// <param name="dotColor">���ڵ����ɫ</param>
        private void ShowWin(int dotColor)
        {
            gamePlayer[0].started = false;
            gamePlayer[1].started = false;
            this.ResetGrid();
            //���͸�ʽ��Win,���ڵ����ɫ,�ڷ��ɼ�,�׷��ɼ�
            service.SendToBoth(this, string.Format("Win,{0}",dotColor));
        }
        /// <summary>��ȥ���ӵ���Ϣ</summary>
        /// <param name="i">ָ�����̵ĵڼ���</param>
        /// <param name="j">ָ�����̵ĵڼ���</param>
        /// <param name="color">ָ��������ɫ</param>
        public void UnsetDot(int i, int j, int color)
        {
            //�������û�������ȥ���ӵ���Ϣ
            //��ʽ��UnsetDot,��,��,�ڷ��ɼ�,�׷��ɼ�
            grid[i, j] = None;
            string str = string.Format("UnsetDot,{0},{1}",
                i, j);
            service.SendToBoth(this, str);
        }

    }
}
