import os, django
os.environ.setdefault("DJANGO_SETTINGS_MODULE", "logohi.settings")
django.setup()
from logo.models import LogoFile
from django.core.files.base import File
import shutil
import re
ext = [".jpg",".png",".gif"]
i=0
for root, dirs, files in os.walk(r"C:\Users\suibianba\Pictures\bzd.files"):
    for file in files:
        if i>1000:
            break
        ff= re.match(r"^\d+", file)
        if ff!=None:
            continue
        if file.endswith(tuple(ext)):
             filePath=os.path.join(root, file)
            # import pdb;pdb.set_trace()
             print(filePath)
             shutil.copyfile(filePath,r"D:\Code\logohi\media\\"+file)

             logo=LogoFile(FileName=file, FilePath=file)
             logo.save()
             i=i+1
