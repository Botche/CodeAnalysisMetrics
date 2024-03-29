﻿### Описание
Проектът представя "Code Smell"-а "Shotgun Surgery". 
В проекта e разписан класa Account, който приема type, accountNumber и amount. В класа са разписани методите Debit, Transfer, SendWarningMessage.

### Причина за рефакторирането
Проблемът е, че във всеки един метод се прави проверка дали amount-а е под някакво определно ниво на пари
като в този случай е зададено 500, ако ни се наложи да го променим на 200, като пример, ще трябва да 
минем през места в кода и да сменим от 500 на 200, което може да доведе до повече грешки. Също нарушаваме и
принципна "Single responsibility" от SOLID, защото по този всеки метод трябва да пази информация за 
минимума, който може да се съдържа в един акаунт.

### Начин на рефакториране
За да се предпазим от този "Code Smell" трябва да изнесем проверката дали имаме по-малко пари от минимума в отделен метод.
Като това ще ни даде възможност да коригираме точно да едно място в кода, ако се наложи такава промяна.
