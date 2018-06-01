using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprite_2D
{
    public enum StateAction
    {
        Left, Right, Up, Down,
        Standing, Walking
    }
    class Sprite2D
    {
        //Vị trí ban đầu của player
        public int x;
        public int y;

        public int dx;
        public int dy;

        public int width;
        public int height;

        //Tỉ lệ nhan vật
        public int defaultScale;
        public int currentScale;

        //Index của từng frame trong tấm hình
        public int indexcomlumn, indexrow;
        public StateAction direction;
        public StateAction action;

        public Sprite2D(bool picture, Bitmap bm)
        {

            x = 50;
            y = 50;

            dx = 0;
            dy = 0;

            currentScale = 1;

            direction = StateAction.Down;
            action = StateAction.Standing;

            width = 56;
            height = 56;

            indexcomlumn = 0;
            indexrow = 0;
        }
        public void drawPlayer(BufferedGraphics buffer, Bitmap bm)
        {
            Rectangle player = new Rectangle(indexcomlumn * width, indexrow * height, width, height);
            Rectangle size_player = new Rectangle(x, y, width * currentScale, height * currentScale);
            buffer.Graphics.DrawImage(bm, size_player, player, GraphicsUnit.Pixel);
            x += dx;
            y += dy;
        }

        public void movePlayer(BufferedGraphics buffer, Bitmap bm)
        {
            switch (action)
            {
                //Đi xuống
                case StateAction.Down:
                    indexrow = 0;
                    if (indexcomlumn >= 0 && indexcomlumn < 3)
                        indexcomlumn++;
                    else
                    {
                        indexcomlumn = 0;
                        dx = 0;
                        dy = 10;
                        direction = StateAction.Down;
                    }
                    break;
                //đi trái 
                case StateAction.Left:
                    indexrow = 1;
                    if (indexcomlumn >= 0 && indexcomlumn < 3)
                        indexcomlumn++;
                    else
                    {
                        indexcomlumn = 0;
                        dx = -10;
                        dy = 0;
                        direction = StateAction.Left;
                    }
                    break;
                //Đi phải
                case StateAction.Right:
                    indexrow = 2;
                    if (indexcomlumn >= 0 && indexcomlumn < 3)
                        indexcomlumn++;
                    else
                    {
                        indexcomlumn = 0;
                        dx = 10;
                        dy = 0;
                        direction = StateAction.Right;
                    }
                    break;
                //Đi lên
                case StateAction.Up:
                    indexrow = 3;
                    if (indexcomlumn >= 0 && indexcomlumn < 3)
                        indexcomlumn++;
                    else
                    {
                        indexcomlumn = 0;
                        dx = 0;
                        dy = -10;
                        direction = StateAction.Up;
                    }
                    break;
                case StateAction.Standing:
                    dx = 0;
                    dy = 0;
                    switch (direction)
                    {
                        case StateAction.Down:
                            indexcomlumn = 0;
                            indexrow = 0;
                            break;
                        case StateAction.Left:
                            indexcomlumn = 0;
                            indexrow = 1;
                            break;
                        case StateAction.Right:
                            indexcomlumn = 0;
                            indexrow = 2;
                            break;
                        case StateAction.Up:
                            indexcomlumn = 0;
                            indexrow = 3;
                            break;
                        default:
                            break;
                    }
                    break;
            }
            drawPlayer(buffer, bm);
        }
    }
}

