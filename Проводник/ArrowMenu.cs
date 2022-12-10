namespace Проводник
{
    class ArrowMenu
    {
         
        public int position;
        int min, max;

        public ArrowMenu(int max)
        {
            min = 0;
            this.max = max;
        }

        public void Down()
        {
            if (position + 1 < max)
            {
                EraseArrow();
                DrawArrow(++position);
            }
        }

        public void Up()
        {
            if (position > min)
            {
                EraseArrow();
                DrawArrow(--position);
            }
        }

        public void DrawArrow(int line)
        {
            position = line;
            Console.SetCursorPosition(0, line);
            Console.WriteLine("->");
        }

        private void EraseArrow()
        {
            Console.SetCursorPosition(0, position);
            Console.Write("  ");
        }

        
    }
}
