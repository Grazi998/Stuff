from bottle import route, redirect, template,request,static_file,run
from adminModel import SQL_LoginModel
import adminControl, nastavnikControl, ucenikControl
import os, sys

dbl=SQL_LoginModel('baza2.db')
dirname = os.path.dirname(sys.argv[0])

@route('/static/<filename:re:.*\.css>')
def send_css(filename):
    return static_file(filename, root=dirname+'/CSS')

@route('/static/<filename:re:.*\.css.map>')
def send_cssmap(filename):
    return static_file(filename, root=dirname+'/CSS')

@route('/static/<filename:re:.*\.js>')
def send_js(filename):
    return static_file(filename, root=dirname+'/js')

@route('/static/<filename:re:.*\.js.map>')
def send_jsmap(filename):
    return static_file(filename, root=dirname+'/js')

@route('/static/<filename:re:.*\.(jpg|png|gif|ico|svg)>')
def send_jsmap(filename):
    return static_file(filename, root=dirname+'/img')

@route('/static/<filename:re:.*\.(jpg|png|gif|ico|svg).map>')
def send_jsmap(filename):
    return static_file(filename, root=dirname+'/img')


@route('/')
def login():
    adminControl.username_global=None
    nastavnikControl.username_global=None
    return template("administracija_html/main")

@route('/', method="POST")
def do_login():
    if request.POST.get("log",'').strip():
        username = request.forms.get('username')
        password = request.forms.get('password')
        rb=request.forms.get('slovo')
        vrsta={'A':0,'N':1,'U':2}
        vr=vrsta[rb]
        ispravan=dbl.login_chek(username,password,vr)
        if ispravan:
            un = username
            if rb=='A':
                
                adminControl.username_global=username
                sys.stderr.write(adminControl.username_global)
                redirect('/izbornikAdmin')
            elif rb=='N':
                nastavnikControl.username_global=username
                redirect('nastavnik/'+un)
            else:
                ucenikControl.username_global=username
                redirect('/ucenik/'+un)
    else:
        return "<p>Login failed.""</p>"


if __name__=='__main__':
    run(reloader=True,port=5555)
