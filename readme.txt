A bolygók textúráját én rajzoltam, egy textúra-atlaszban vannak eltárolva
A bolygók forgási sebessége és távolsága egyenesen arányos a naptól való távolságukkal - természetesen működne a program egyedi értékekkel is
A bolygókkal kapcsolatos dolgokat instanced renderinggel hatékonyabban is meg lehetett volna csinálni, de inkább maradtam a biztosnál
Az 'L' gombbal lehet a lámpát be- és kikapcsolni, a távolsággal lineárisan csökken az intenzitás, nem pedig négyzetesen
A Nap fénye is lineárisan csökken
A csillagos ég egy skybox cubemappel implementálva, textúra innen https://danielilett.com/2019-12-11-tut4-1-spyro-skyboxes/

A lámpa és a cubemap kód a learnopengl.com-ról származik részben