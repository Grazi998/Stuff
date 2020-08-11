import sqlite3

class SQLUcenikModel():

    def __init__(self,filename):
        self.conn=sqlite3.Connection(filename)
        self.cur=self.conn.cursor()
        self.filename=filename
        self.cur.executescript("""
            CREATE TABLE IF NOT EXISTS Ucenik(
              mb integer INTEGER PRIMARY KEY,
              ime text NOT NULL,
              prezime text NOT NULL,
              razredID integer NOT NULL,
              username text NOT NULL,
              FOREIGN KEY (razredID) REFERENCES Razred (mb));
              
           CREATE TABLE IF NOT EXISTS Ocjena (
             mb integer PRIMARY KEY,
             ocjena integer,
             datum DATETIME NOT NULL,
             predmetID integer NOT NULL,
             ucenikID integer NOT NULL,
             nastavnik text NOT NULL,
             FOREIGN KEY (predmetID) REFERENCES Predmet (mb),
             FOREIGN KEY (ucenikID) REFERENCES Ucenik (mb));

""")


    def ucenik_select(self,mb=None):
        if mb is not None:
            mb=str(mb)
        if (mb is None):
            self.cur.execute("""SELECT u.mb, u.ime, u.prezime, r.razina, r.odjeljenje, u.username FROM Ucenik u INNER JOIN Razred r ON r.mb=u.RazredID ORDER BY PREZIME """)
        else:
            if (mb.isnumeric()):
                self.cur.execute("""SELECT u.mb, u.ime, u.prezime, r.razina, r.odjeljenje, u.username FROM Ucenik u INNER JOIN Razred r ON r.mb=u.RazredID WHERE u.mb=? ORDER BY PREZIME """,(mb,))
            else:
                self.cur.execute(
                    """SELECT u.mb, u.ime, u.prezime, r.razina, r.odjeljenje, u.username FROM Ucenik u INNER JOIN Razred r ON r.mb=u.RazredID WHERE u.prezime LIKE ? ORDER BY PREZIME """,('%' + mb + '%',))

        return  self.cur.fetchall()
    def ucenik_select_podaci(self,mb):
            self.cur.execute("""SELECT u.ime, u.prezime, u.mb, u.username, r.razina, r.odjeljenje, n.ime, n.prezime FROM Ucenik u INNER JOIN Razred r ON u.razredID=r.mb  INNER JOIN Natavnik n ON r.razrednikID=n.mb WHERE u.ucenikID= ? and r.razrednikID IS NOT NULL ORDER BY u.mb """)
            return self.cur.fetchall()
    def ucenik_select_mb(self,username):
        self.cur.execute("""SELECT mb FROM Ucenik WHERE username = ?""")
        return self.cur.fetchall()
        
    def ucenik_insert(self, ime, prezime,razred,slovo):
            self.cur.execute("""SELECT mb FROM Ucenik""")
            id=self.cur.fetchall()
            ime,prezime,razred,slovo=self.titlovanje_imena(ime,prezime,razred,slovo)
            id=[int(i[0]) for i in id]
            mb=self.provjeri_razmak(id)
            un=str(mb)+'u'
            r = SQLRazredModel(self.filename)
            razredID=r.get_razred_mb(razred,slovo)
            self.cur.execute("""
                INSERT INTO Ucenik
                (mb, ime, prezime, razredID, username)
                VALUES (?, ?, ?, ?, ?)""", (mb, ime, prezime,razredID,un))
            self.conn.commit()
            return  un

    def ucenik_delete(self, mb):
        red=self.ucenik_select(mb)
        self.cur.execute("""SELECT username From Ucenik WHERE mb=?""",(mb,))
        un=self.cur.fetchall()[0][0]
        self.cur.execute("""
            DELETE FROM Ucenik
            WHERE mb = ?""", (mb, ))
        self.conn.commit()
        return un
    def provjeri_razmak(self, lista_id):
        for i in range(0,len(lista_id)):
            if  (i+1)not in lista_id:
                return i+1
        return  len(lista_id)+1
    def titlovanje_imena(self, ime, prezime,razred,slovo):
         return (ime.title(),prezime.title(),int(razred),slovo.upper())
    def ucenik_edit(self,mb,ime,prezime,razred,odjeljenje):
        ime,prezime,razred,odjeljenje=self.titlovanje_imena(ime,prezime,razred,odjeljenje)
        r=SQLRazredModel(self.filename)
        ID=r.get_razred_mb(razred,odjeljenje)
        self.cur.execute("""UPDATE Ucenik SET
                            ime = ?, prezime = ?, razredID = ? WHERE mb = ? """,(ime,prezime,ID,mb))
        self.conn.commit()
    def ocjene_select(self,mb):
            self.cur.execute("""SELECT o.mb,o.ocjena,o.datum,o.predmetID,o.nastavnik, o.ucenikID FROM Ocjena o INNER JOIN Ucenik u ON u.mb=o.ucenikID  INNER JOIN Predmet p ON p.mb=o.predmetID WHERE u.ucenikID= ? and p.predmetID= ? ORDER BY o.predmetID""",(mb,))
            return self.cur.fetchall()
    
