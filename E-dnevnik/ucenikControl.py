from bottle import route, request, redirect
from UcenikModel import SQLUcenikModel
from ucenikView import  UcenikView


dbu=SQLUcenikModel('baza2.db')
#dbo=SQL_OcjenaModel('baza2.db')
username_global=None
un=None
ui=UcenikView()
def neispravanIdentitet():
    return '<h1> Zabranjen pristup prijavite se: <a href="/">ovdje</a></h1>'
# OCJENE popis
@route('/ucenik/<username>')
def ucenik_izbornik_ocjene(username):
    global username_global
    if (username_global is None): return neispravanIdentitet()
    mb=ucenik_select_mb(username)[0][0]
    podaci=dbu.ucenik_select_podaci(mb=mb)[0]
    #u selectu triba bit :  ime prezime, maticni broj ,razred, razradnik ako ga ima , username , u uceniku
    ocjene=dbo.ocjene_select(mb)
    #ovo ocjene sadrze: o.mb,o.ocjena,o.datum,o.predmetID,o.nastavnik, o.ucenikID
    ocjene_po_predmetima= {}
    for mb,ocjena,datum,predmet,nastavnik,ucenik in ocjene:
        if str(predmet) in ocjene_po_predmetima.keys():
            ocjene_po_predmetima[str(predmet)]+=[mb,ocjena,datum,nastavnik,ucenik]
        else:
            ocjene_po_predmetima[str(predmet)]=[[mb,ocjena,datum,nastavnik,ucenik]]
    return  ui.o_osobni_ocjene(ocjene_po_predmetima,podaci)
