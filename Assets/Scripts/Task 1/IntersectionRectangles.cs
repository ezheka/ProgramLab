using System;
using UnityEngine;
using UnityEngine.UI;

public class IntersectionRectangles : MonoBehaviour
{
    public Rectangle rectangle_1, rectangle_2;
    public Text textAnswer;

    int _leftCornerRectangleX_1, _leftCornerRectangleY_1, _rightCornerRectangleX_1, _rightCornerRectangleY_1;
    int _leftCornerRectangleX_2, _leftCornerRectangleY_2, _rightCornerRectangleX_2, _rightCornerRectangleY_2;
    int _a, _b; //высота и ширина для нахождения площади
    private void Update()
    {
        

        

        //float leftCornerRectangleY_1 = Rectangle._y2 - Rectangle._h1;

        //if()

        //

        //float centerRectangleX_2 = Rectangle._x2 - (Rectangle._w2 / 2);
        //float centerRectangleY_2 = Rectangle._y2 - (Rectangle._h2 / 2);

    }



    public void CalculatingInteresectionArea()
    {
        //левый верхний угол первого прямоугольника
        _leftCornerRectangleX_1 = Convert.ToInt32(rectangle_1.CoordinateX.text);
        _leftCornerRectangleY_1 = Convert.ToInt32(rectangle_1.CoordinateY.text);
        //правый нижний угол первого прямоугольника
        _rightCornerRectangleX_1 = Convert.ToInt32(rectangle_1.CoordinateX.text) + Convert.ToInt32(rectangle_1.Width.text);
        _rightCornerRectangleY_1 = Convert.ToInt32(rectangle_1.CoordinateY.text) + Convert.ToInt32(rectangle_1.Height.text);

        //левый верхний угол второго прямоугольника
        _leftCornerRectangleX_2 = Convert.ToInt32(rectangle_2.CoordinateX.text);
        _leftCornerRectangleY_2 = Convert.ToInt32(rectangle_2.CoordinateY.text);
        //правый нижний угол второго прямоугольника
        _rightCornerRectangleX_2 = Convert.ToInt32(rectangle_2.CoordinateX.text) + Convert.ToInt32(rectangle_2.Width.text);
        _rightCornerRectangleY_2 = Convert.ToInt32(rectangle_2.CoordinateY.text) + Convert.ToInt32(rectangle_2.Height.text);


        //проверка на пересечение по координате y
        if ((_leftCornerRectangleY_2 >= _leftCornerRectangleY_1) && (_leftCornerRectangleY_2 <= _rightCornerRectangleY_1))//пересечение справа
        {
            _b = _rightCornerRectangleY_1 - _leftCornerRectangleY_2;
            Debug.Log(_b);
        }
        if((_leftCornerRectangleY_2 <= _leftCornerRectangleY_1) && (_leftCornerRectangleY_2 >= _rightCornerRectangleY_1))//пересечение слева
        {
            _b = _leftCornerRectangleY_1 - _rightCornerRectangleY_2;
            Debug.Log(_b);
        }

        //проверка на пересечение по координате x
        if ((_leftCornerRectangleX_1 >= _leftCornerRectangleX_2) && (_rightCornerRectangleX_1 >= _rightCornerRectangleX_2))//пересечение сверху
        {
            _a = _rightCornerRectangleX_1 - _leftCornerRectangleX_1;
            Debug.Log(_a);
        }
        if ((_leftCornerRectangleX_1 <= _leftCornerRectangleX_2) && (_rightCornerRectangleX_1 <= _rightCornerRectangleX_2))//пересечение снизу
        {
            _a = _rightCornerRectangleX_1 - _leftCornerRectangleX_2;
            Debug.Log(_a);
        }

        //Проверка назаполненность a и b.
        if (_a != 0 && _b != 0)
        {
            int S = _a * _b; //Нахождение площади
            textAnswer.text = "Площадь пересечения = " + S.ToString();
        }
    }
}
