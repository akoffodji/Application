---
### Application

---
### Livrable 1

1. Ouvrir un terminal dans le répertoire **ele4205-p15-06** et faire les commandes suivantes:


        $ git pull
        $ source /export/tmp/4205_6/opt/poky/environment-setup-cortexa8hf-vfp-neon-poky-linux-gnueabi
        $ mkdir Livrable_1_4/build
        $ cd Livrable_1_4/build/
        $ cmake -v -DCMAKE_BUILD_TYPE=Release   -DOpenCV_DIR:STRING="/export/tmp/4205_6/poky/build_pwm/tmp/sysroots/beaglebone/usr/share/OpenCV" ..
        $ make


2. Copier l'exécutable **projet** dans le dossier **bin/** de la partition **root** sur la carte SD.

3. Démarrer votre BBB et lancer l'exécutable **projet** .

---

### Livrable 2

1. Ouvrir un nouveau terminal dans le répertoire **ele4205-p15-06** et faire les commandes suivantes:


        $ git pull
        $ source /export/tmp/4205_6/opt/poky/environment-setup-cortexa8hf-vfp-neon-poky-linux-gnueabi
        $ mkdir Livrable_1_4/build
        $ cd Livrable_1_4/build/
        $ cmake -v -DCMAKE_BUILD_TYPE=Release -DOpenCV_DIR:STRING="/export/tmp/4205_6/poky/build_pwm/tmp/sysroots/beaglebone/usr/share/OpenCV" ..
        $ make



2. Copier l'exécutable **projet** dans le dossier **bin/** de la partition **root** sur la carte SD.

3. Démarrer votre BBB et lancer l'exécutable **projet** .

4. Sélectionner le **livrable 2** et faire l'option **Serveur** 

5. Ouvrir un nouveau terminal dans le répertoire **ele4205-p15-06** et faire les commandes suivantes:


        $ mkdir Livrable_1_4/build_linux
        $ cd Livrable_1_4/build_linux
        $ cmake -v -DCMAKE_BUILD_TYPE=Release -DOpenCV_DIR:STRING="/export/tmp/4205_6/opencv-2.4.11/build" ..
        $ make
        $ ./projet
        
6. Sélectionner le **livrable 2** et faire l'option **Client** 

7. Le serveur et le client peuvent maintenant communiquer. 

8. Sélectionner la résolution souhaitée et appuyer sur la touche **ESC** pour terminer le streaming.

---

### Livrable 3

1. Ouvrir un nouveau terminal dans le répertoire **ele4205-p15-06** et faire les commandes suivantes:


        $ git pull
        $ source /export/tmp/4205_6/opt/poky/environment-setup-cortexa8hf-vfp-neon-poky-linux-gnueabi
        $ mkdir Livrable_1_4/build
        $ cd Livrable_1_4/build/
        $ cmake -v -DCMAKE_BUILD_TYPE=Release -DOpenCV_DIR:STRING="/export/tmp/4205_6/poky/build_pwm/tmp/sysroots/beaglebone/usr/share/OpenCV" ..
        $ make



2. Copier l'exécutable **projet** dans le dossier **bin/** de la partition **root** sur la carte SD.

3. Démarrer votre BBB et lancer l'exécutable **projet** .

4. Sélectionner le **livrable 3** et faire l'option **Serveur** 

5. Ouvrir un nouveau terminal dans le répertoire **ele4205-p15-06** et faire les commandes suivantes:


        $ mkdir Livrable_1_4/build_linux
        $ cd Livrable_1_4/build_linux
        $ cmake -v -DCMAKE_BUILD_TYPE=Release -DOpenCV_DIR:STRING="/export/tmp/4205_6/opencv-2.4.11/build" ..
        $ make
        $ ./projet

6. Sélectionner le **livrable 3** et faire l'option **Client** 

7. Le serveur et le client peuvent maintenant communiquer. 

8. Sélectionner la résolution souhaitée et appuyer sur la touche **ESC** pour terminer le streaming et fermer les connexions.

9. Appuyer sur le boutton pour faire un snapshot ou couvrer le capteur de lumière pour arrêter temporairement le streaming.

---

### Livrable 4

1. Ouvrir un nouveau terminal dans le répertoire **ele4205-p15-06** et faire les commandes suivantes:


        $ git pull
        $ source /export/tmp/4205_6/opt/poky/environment-setup-cortexa8hf-vfp-neon-poky-linux-gnueabi
        $ mkdir Livrable_1_4/build
        $ cd Livrable_1_4/build
        $ cmake -v -DCMAKE_BUILD_TYPE=Release -DOpenCV_DIR:STRING="/export/tmp/4205_6/poky/build_pwm/tmp/sysroots/beaglebone/usr/share/OpenCV" ..
        $ make



2. Copier l'exécutable **projet** dans le dossier **bin/** de la partition **root** sur la carte SD.

3. Démarrer votre BBB et lancer l'exécutable **projet** .

4. Sélectionner le **livrable 4** et faire l'option **Serveur** 

5. Ouvrir un nouveau terminal dans le répertoire **ele4205-p15-06** et faire les commandes suivantes:


        $ mkdir Livrable_1_4/build_linux
        $ cd Livrable_1_4/build_linux
        $ cmake -v -DCMAKE_BUILD_TYPE=Release -DOpenCV_DIR:STRING="/export/tmp/4205_6/opencv-2.4.11/build" ..
        $ make
        $ ./projet

6. Sélectionner le **livrable 4** et faire l'option **Client** 

7. Le serveur et le client peuvent maintenant communiquer. 

8. Sélectionner la résolution souhaitée et appuyer sur la touche **ESC** pour terminer le streaming et fermer les connexions.

9. Appuie sur l'une des touches **Haut** ou **Bas** du clavier pour augmenter ou diminuer la résolution.

10. Appuyer sur le boutton pour faire un snapshot ou couvrer le capteur de lumière pour arrêter temporairement le streaming.

---

### Livrable 5

1. Ouvrir un nouveau terminal dans le répertoire **ele4205-p15-06** et faire les commandes suivantes:


        $ mkdir Livrable_1_5/build_linux
        $ cd Livrable_1_5/build_linux
        $ cmake -v -DCMAKE_BUILD_TYPE=Release -DOpenCV_DIR:STRING="/export/tmp/4205_6/opencv-2.4.11/build" ..
        $ make
        $ ./projet

2. Sélectionner le **livrable 5**

3. S'assurer que le dossier courant contient une image de carte d'étudiant au sous le nom de fichier *test2.jpeg*

3. Le nom, le prénom et le matricule s'affichent s'il n'y a pas d'erreurs

---
