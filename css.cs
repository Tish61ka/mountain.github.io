html{
    margin: -20px -10px -20px -10px;
    background-color: white;
    width: 100%;
     }
body{
   width: 100%;
}
section{
   margin-bottom: 100px;
}

/* Начало 1 секции */
.phon_section_1{
   background-image: url(Phon.jpg);
   height: 800px;
   background-size: 100%;
   padding: 0px;
   margin: 0px;
   background-repeat: no-repeat;
}
.h_section_1{
   text-align: center;
   font-size: 90px;
   font-family: Century Gothic;
   color: white;
   margin-top: 180px;
}
@keyframes rgb-button {
   from{
       border: 2px solid rgb(177, 176, 176);
   }
   25%{
       border: 2px solid rgb(126, 126, 126);
   }
   50%{
       border: 2px solid rgb(224, 224, 224);
   }
   75%{
       border: 2px solid rgb(255, 255, 255);
   }
   90%{
       border: 2px solid rgb(223, 223, 223);
   }
   to{
       border: 2px solid rgb(163, 163, 163);
   }
}
.button_section_1{
   display: inline-block;
   width: 200px;
   height: 20px;
   margin: 10px 0 0 43%;
   position: relative;
   animation: rgb-button 3s linear infinite normal;
}
.button_text{
   text-align: center;
   font-size: 16px;
   font-family: Century Gothic;
   padding: 10px;  
}
a{
   text-decoration: none;
    color: white;
    text-align: center;
}

/* Начало навигации*/
nav{
   margin-left: 20%;
}
/* убираем отступы и поля, а также list-style для "ul", 
* и добавляем "position:relative" */
nav ul {
   padding:0;
   margin:0;
   list-style: none;
   position: relative;
   }
.li{
   width: 180px;
   font-family: Century Gothic;
}   
/* применяем inline-block позиционирование к элементам навигации */
nav ul .li {
   margin: 0px -7px 0 0;
   display:inline-block;
   }
/* стилизуем ссылки */
nav .a {
   display:block;
   padding:0 10px;
   color:#FFF;
   font-size:20px;
   line-height: 60px;
   text-decoration:none;
}
/* изменяем цвет фона при наведении курсора */
nav .a:hover {
   background: radial-gradient(ellipse at center, rgba(242,242,242,0.36) 0%,rgba(224,228,229,0.19) 48%,rgba(224,228,229,0.01) 100%);
}
nav ul ul {
   display: none;
   position: absolute;
   top: 100%;
}
/* отображаем выпадающий список при наведении */
nav ul .li:hover > ul {
   display:inherit;
}
/* первый уровень выпадающего списка */
nav ul ul .li {
   float:none;
   display:list-item;
   position: relative;
}

/* Начало 2 секции */
.h_section_2{
   letter-spacing: 0.1px;
   font-size: 40px;
   font-family: Century Gothic;
   padding: 30px 0 0 100px;
}
.text_section_2{
   font-size: 18px;
   font-family: Helvetica;
   line-height: 1,5px;
   padding: 0 0 0 100px;
}
.picture_map{
   float: right;
   margin-top: 170px;
} 

/* начало таблицы */
.back_3{
   background: url(photo-23.jpg);
   background-size: 100%;
   background-repeat: no-repeat;
   height: 650px;
}
.rus{
  font-size: 40px;
  font-family: Century Gothic;
  color: white;
  text-align: center;
  padding-top: 30px;
}
.caption{
  text-align: center;
  color: white;
  margin-bottom: 3%;
  font-family: Helvetica;
}
table{
  margin-right: 50px;
  text-align: center;
  width: 100%;
}
tbody{
  font-family: Helvetica;
  font-size: 20px;
  color: white;
}
tr:hover{
  color: red;
}
tr{
  margin: 0px 100px;
}
th{
  width: 320px;
  color: grey;
  font-size: 20px;
  border-bottom: 0.5px solid grey;
}
.th-money:hover{
  text-decoration: underline;
  color: red;
}
td{
  padding-top: 35px;
  padding-bottom: 15px;
  margin-top: 50px;
  width: 320px;
  border-bottom: 2px solid grey;
}
.button{
  width: 150px;
  height: 50px;
  padding: 0px 20px;
  margin-top: 20px;
  text-align: center;
  margin-left: 45%;
  background: transparent;
  border: 2px white solid;
  font-family: Century Gothic; 
  border-radius: 70px 30px;
  color: white;
}
.button:hover{
  background-color: #060714;
  box-shadow: 0 5px 4px #000000;
  color: white;
}
/* Начало секции с формой */
.section-form{
   background-color: #071A29;
   font-family: Century Gothic;
}
.float-form{
   float: left;
   margin-left: 100px;
}
.h-form{
   width: 600px;
   font-size: 50px;
   color: #ffffff;
}
.p-form{
   width: 500px;
   font-size: 16px;
   color: #ffffff;
}
input{
   background: transparent;
   color: grey;
   width: 370px;
   padding-bottom: 5px;
   padding-top: 5px;
   font-size: 14px;
   border: none;
   border-bottom: 1px solid grey;
   transition: width 0.4s ease-in-out;
}
input:focus{
   width: 450px;
}
.p-form_2{
   margin-bottom: 20px;
   color: grey;
   font-size: 12px;
   font-family: Century Gothic;
}
.button-form{
   font-size: 16px;
   background-color: #ec5118;
   width: 450px;
   height: 50px;
   text-align: center;
   margin-top: 40px;
   color: #ffffff;
}
.p-form-comment{
   font-size: 12px;
   color: #ffffff;
}
.img-form{
   margin-left: 800px;
   background-image: url(photo-33.jpg);
   height: 600px;
}

/* Начало секции с контактной информацией */
.contacts{
   height: 550px;
   margin-top: 50px;
   padding-left: 30px;
}
.h_section_contacts{
   font-size: 50px;
   font-family: Century Gothic;
   margin-bottom: 30px;
}
.picture_map_section_contacts{
   float: left;
   margin-right: 70px;
   padding-left: 75px;
}
.small_text{
   font-family: Helvetica;
   font-size: 16px;
   margin-bottom: 25px;
   line-height: 1.5px;
}
.big_text{
   font-family: Helvetica;
   font-size: 18px;
   margin-bottom: 25px;
}
.fac_inst_twit{
   display: inline-block;
   letter-spacing: 50px;
   margin-right: 50px;
}
.icon{
   text-align: left;
   margin-left: 70px;
}

/* Начало подвала */
footer{
   background-color: #071a29;
   padding-top: 50px;
   margin-top: 50px;
   height: 80px;
}
.foot_picture{
   margin-left: 46%;
}
