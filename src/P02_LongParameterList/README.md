﻿### Описание
Проектът представя "Code Smell"-а "Long parameter list". 
В проекта са разписани класовете Rectangle и Triangle, които приемат при създаването си 
приемат координати на точките, които ги описват, и ги запазват в пропъртита.

### Причина за рефакторирането
Проблемът е, че приемаме координати X и Y за всяка точка отделно, което с повишаване на броя на точките се отразява на 
броя на параметрите в конструктора по две, ако имаме 5 точки, ще имаме 10 параметъра в конструктора.
Този проблем е описан като "Long parameter list", който се води "Code Smell".

### Начин на рефакториране
За да се рефакторираме нашият код така, че да избегнем "Long parameter list", трябва да приемаме в конструктора обекти от тип точка, за да намалим двойно броят
на параметрите в конструктора.
По-този начин също оставаме отворени за модификации по кода като например, ако имаме нужда след време да поддържаме 3D обекти, само ще трябва да добавим
още едно пропърти в Point - Z, а броят на параметрите в конструктора на Rectangle и Triangle ще остане същият.