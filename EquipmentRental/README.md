Equipment Rental System

Aplikacja konsolowa w C# służąca do obsługi uczelnianej wypożyczalni sprzętu.  
System umożliwia dodawanie sprzętu i użytkowników, wypożyczanie, zwroty, kontrolę dostępności i generowanie raportu.
---
Zawiera klasy reprezentujące dane:
- Equipment + Laptop, Camera, Projector
- User + Student, Employee
- Rental


  Zawiera logikę biznesową:
- EquipmentService
- UserService
- RentalService

Każdy serwis posiada interfejs.

Zawiera wyjątki:
- EquipmentNotFoundException
- UserNotFoundException
- RentalLimitException
- EquipmentUnavailableException
- RentalNotFoundException
---
- Models odpowiada za dane
- Services odpowiadają za logikę biznesową
- Exceptions customowe wyjątki
- Program.csuruchamia scenariusz

Każda klasa ma jedną odpowiedzialność i zastosowano interfejsy dzięki czemu serwisy są mniej zalezne

Uruchomienie:
- Otwórz Rider
- Uruchom program.cs
---
Autor: Bartosz Denejko