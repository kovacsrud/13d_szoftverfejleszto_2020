

jelenlegiOra=int(input("Add meg a jelenlegi órát:"))

if jelenlegiOra>=8 and jelenlegiOra<16:
    print("A bolt nyitva van!")
    print("A nyitva tartásból hátra van:",16-jelenlegiOra)
else:
    print("A bolt zárva van!")

