using System;

namespace WindowsFormsMainApplication
{
    class CaesarArithmetic
    {
        //���o�r�Ū�ASCII�X
        public int AscII(string str)
        {
            byte[] array = new byte[1];//�إߦr�`�}�C
            array = System.Text.Encoding.ASCII.GetBytes(str);//���r�`�}�C���
            int asciicode = (short)(array[0]);//���o�r�`�}�C���Ĥ@��
            return asciicode;//��^�r�`�}�C���Ĥ@��
        }
        public string Caesar(string str)//�ͼ��[�K��k����{
        {
            char[] c = str.ToCharArray();//�إߦr�Ű}�C
            string strCaesar = "";//�w�q�@���ܼơA�ΨӦs�x�[�K�᪺�r��
            for (int i = 0; i < str.Length; i++)//�`�׷j�M�r�ꤤ���C�@�Ӧr��
            {
                string ins = c[i].ToString();//�O���`�׷j�M�쪺�r��
                string outs = "";//�w�q�@���ܼơA�ΨӰO���[�K�᪺�r��
                bool isChar = "0123456789abcdefghijklmnopqrstuvwxyz".Contains(ins.ToLower());//�P�_���w���r�ꤤ�O�_�]�t�`�׷j�M�쪺�r��
                bool isToUpperChar = isChar && (ins.ToUpper() == ins);//�P�_�`�׷j�M�쪺�r�ŬO�_�O�j�g
                ins = ins.ToLower();//�N�`�׷j�M�쪺�r���ഫ���p�g
                if (isChar)//�P�_���w���r�ꤤ�O�_�]�t�`�׷j�M�쪺�r��
                {
                    int offset = (AscII(ins) + 5 - AscII("a")) % (AscII("z") - AscII("a") + 1);//���o�r�Ū�ASCII�X
                    outs = Convert.ToChar(offset + AscII("a")).ToString();//�ഫ���r�ŨðO��
                    if (isToUpperChar)//�P�_�O�_�j�g
                    {
                        outs = outs.ToUpper();//�����ഫ���j�g
                    }
                }
                else
                {
                    outs = ins;//�O���`�׷j�M���r��
                }
                strCaesar += outs;//�s�W��[�K�r�ꤤ
            }
            return strCaesar;//��^�[�K�᪺�r��
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("�п�J�K�X�G");
                string P_str_Code = Console.ReadLine();//�O���n�[�K���K�X
                CaesarArithmetic program = new CaesarArithmetic();//�إ�Program����
                Console.WriteLine("�ϥγͼ��t��k�[�K�᪺���G���G" + program.Caesar(P_str_Code));//��X�[�K�᪺�r��
            }
        }
    }
}
