//神里涩涩 Ayaka sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Sword_Ayaka(Clone)/OffsetDummy/Avatar_Girl_Sword_Ayaka/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//申鹤涩涩 Shenhe sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Lady_Pole_Shenhe(Clone)/OffsetDummy/Avatar_Lady_Pole_Shenhe/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,42,43,44,45,46,47,48";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
    float Scale = float.Parse(strScales[i]);
    Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
    matrix4x4.m00 *= Scale;
    matrix4x4.m10 *= Scale;
    matrix4x4.m20 *= Scale;
    matrix4x4.m30 *= Scale;
    matrix4x4.m01 *= Scale;
    matrix4x4.m11 *= Scale;
    matrix4x4.m21 *= Scale;
    matrix4x4.m31 *= Scale;
    matrix4x4.m02 *= Scale;
    matrix4x4.m12 *= Scale;
    matrix4x4.m22 *= Scale;
    matrix4x4.m32 *= Scale;
    matrix4x4.m03 *= Scale;
    matrix4x4.m13 *= Scale;
    matrix4x4.m23 *= Scale;
    matrix4x4.m33 *= Scale;
    matrix4x4s[int.Parse(index)] = matrix4x4;
    Debug.Log(matrix4x4s[int.Parse(index)].ToString());
    i++;
}
mesh.bindposes = matrix4x4s;

//刻晴皮肤涩涩 Keqing skin sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Sword_KeqingCostumeFeather(Clone)/OffsetDummy/Avatar_Girl_Sword_KeqingCostumeFeather/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//芭芭拉涩涩（半去裙子）Barbara sex version1
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Catalyst_Barbara(Clone)/OffsetDummy/Avatar_Girl_Catalyst_Barbara/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "42,43,91,92,93,94,95,96,97,98,99,100,101,102";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//甘雨涩涩 Ganyu sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Bow_Ganyu(Clone)/OffsetDummy/Avatar_Girl_Bow_Ganyu/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//芭芭拉皮肤涩涩 Barbara skin sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Catalyst_BarbaraCostumeSummertime(Clone)/OffsetDummy/Avatar_Girl_Catalyst_BarbaraCostumeSummertime/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "19,20,21,22,23,24,25,26,27,28,29,30";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//罗莎莉亚涩涩 Rosaria sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Lady_Pole_Rosaria(Clone)/OffsetDummy/Avatar_Lady_Pole_Rosaria/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//宵宫涩涩 Yoimiya sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Bow_Yoimiya(Clone)/OffsetDummy/Avatar_Girl_Bow_Yoimiya/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "29,30,31,32,33,34,40,41,42,43,44,45";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//雷神涩涩 Shogun sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Lady_Pole_Shougun(Clone)/OffsetDummy/Avatar_Lady_Pole_Shougun/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,48,49,50,51";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//刻晴涩涩 Keqing sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Sword_Keqing(Clone)/OffsetDummy/Avatar_Girl_Sword_Keqing/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//九条涩涩 Sara sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Lady_Bow_Sara(Clone)/OffsetDummy/Avatar_Lady_Bow_Sara/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//八重涩涩 Yae sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Lady_Catalyst_Yae(Clone)/OffsetDummy/Avatar_Lady_Catalyst_Yae/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "37,38,39,40,44,45,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//凝光涩涩 Ningguang sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Lady_Catalyst_Ningguang(Clone)/OffsetDummy/Avatar_Lady_Catalyst_Ningguang/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "52,53,54,55,56,57,58,59,60,61,62,99,100,101,102,105,106,107,108,109,110,111,112,113,114,115,116,117,118";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//凝光皮肤涩涩 Ningguang skin sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Lady_Catalyst_NingguangCostumeFloral(Clone)/OffsetDummy/Avatar_Lady_Catalyst_NingguangCostumeFloral/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//心海涩涩 Kokomi sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Catalyst_Kokomi(Clone)/OffsetDummy/Avatar_Girl_Catalyst_Kokomi/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//丽莎涩涩 Lisa sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Lady_Catalyst_Lisa(Clone)/OffsetDummy/Avatar_Lady_Catalyst_Lisa/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//丽莎去帽 Lisa cap
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Lady_Catalyst_Lisa(Clone)/OffsetDummy/Avatar_Lady_Catalyst_Lisa/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "8,9,10,11,12,13,14,15";
string strPartsSetScales = "0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//北斗涩涩 Beidou sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Lady_Claymore_Beidou(Clone)/OffsetDummy/Avatar_Lady_Claymore_Beidou/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "28,35,36,56,57,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//菲谢尔涩涩 Fischl sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Bow_Fischl(Clone)/OffsetDummy/Avatar_Girl_Bow_Fischl/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//辛炎涩涩 Xinyan sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Claymore_Xinyan(Clone)/OffsetDummy/Avatar_Girl_Claymore_Xinyan/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "80,81,82,83,84,85";
string strPartsSetScales = "0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//烟绯涩涩 Yanfei sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Catalyst_Feiyan(Clone)/OffsetDummy/Avatar_Girl_Catalyst_Feiyan/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "20,21,22,23,24,25,26,27,28,29,30,31,32,33";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//香菱涩涩 Xiangling sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Pole_Xiangling(Clone)/OffsetDummy/Avatar_Girl_Pole_Xiangling/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "62,63,64,65,66,67,68,69,72,73,74,75,76";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//芭芭拉涩涩（全涩）Barbara sex version2
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Catalyst_Barbara(Clone)/OffsetDummy/Avatar_Girl_Catalyst_Barbara/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "35,37,41,42,43,46,48,49,50,91,92,93,94,95,96,97,98,99,100,101,102";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//云锦涩涩 Yun jin sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Pole_Yunjin(Clone)/OffsetDummy/Avatar_Girl_Pole_Yunjin/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "48,49,50,52,53,54,56,57,58,59,61,62,63,64,66,67,68,70,71,73,74";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//砂糖涩涩 Sucrose
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Catalyst_Sucrose(Clone)/OffsetDummy/Avatar_Girl_Catalyst_Sucrose/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "85,86,87,88,90,91,92,94,95,96";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//诺埃尔涩涩 Noelle sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Claymore_Noel(Clone)/OffsetDummy/Avatar_Girl_Claymore_Noel/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "62,63,64,66,67,68,69,71,72,73,75,76,77,78,80,81,82,84,85,86,88,89,90,96,97";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;

//旅行者涩涩 Lumine sex
var obj = GameObject.Find("EntityRoot/AvatarRoot/Avatar_Girl_Sword_PlayerGirl(Clone)/OffsetDummy/Avatar_Girl_Sword_PlayerGirl/Body");
SkinnedMeshRenderer smr = obj.GetComponent<SkinnedMeshRenderer>();
Mesh mesh = smr.sharedMesh;
//要调整缩放的部位索引和缩放大小 以逗号,分隔
string strPartsIndexs = "83,84,86,87,88,90,91,93,94,95,97,98,100,101,103,104";
string strPartsSetScales = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
string[] strPartsIndexList = strPartsIndexs.Trim().Split(',');
string[] strScales = strPartsSetScales.Trim().Split(',');
Log(strPartsIndexList.Length+"|"+strScales.Length);
Matrix4x4[] matrix4x4s = mesh.bindposes;
int i = 0;
foreach(string index in strPartsIndexList)
{
	float Scale = float.Parse(strScales[i]);
	Matrix4x4 matrix4x4 = mesh.bindposes[int.Parse(index)];
	matrix4x4.m00 *= Scale;
	matrix4x4.m10 *= Scale;
	matrix4x4.m20 *= Scale;
	matrix4x4.m30 *= Scale;
	matrix4x4.m01 *= Scale;
	matrix4x4.m11 *= Scale;
	matrix4x4.m21 *= Scale;
	matrix4x4.m31 *= Scale;
	matrix4x4.m02 *= Scale;
	matrix4x4.m12 *= Scale;
	matrix4x4.m22 *= Scale;
	matrix4x4.m32 *= Scale;
	matrix4x4.m03 *= Scale;
	matrix4x4.m13 *= Scale;
	matrix4x4.m23 *= Scale;
	matrix4x4.m33 *= Scale;
	matrix4x4s[int.Parse(index)] = matrix4x4;
	Debug.Log(matrix4x4s[int.Parse(index)].ToString());
	i++;
}
mesh.bindposes = matrix4x4s;
