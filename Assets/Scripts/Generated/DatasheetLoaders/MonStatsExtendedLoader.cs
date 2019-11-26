
// It's generated file. DO NOT MODIFY IT!
class MonStatsExtendedLoader : Datasheet.Loader<MonStatsExtended>
{

    public void LoadRecord(ref MonStatsExtended record, Datasheet.Stream stream)
    {
                stream.Read(ref record.id);
                stream.Read(ref record.height);
                stream.Read(ref record.OverlayHeight);
                stream.Read(ref record.pixHeight);
                stream.Read(ref record.sizeX);
                stream.Read(ref record.sizeY);
                stream.Read(ref record.spawnCol);
                stream.Read(ref record.meleeRng);
                stream.Read(ref record.baseWeaponClass);
                stream.Read(ref record.HitClass);
                record.gearVariantsStr = new string[16];
                    stream.Read(ref record.gearVariantsStr[0]);
                    stream.Read(ref record.gearVariantsStr[1]);
                    stream.Read(ref record.gearVariantsStr[2]);
                    stream.Read(ref record.gearVariantsStr[3]);
                    stream.Read(ref record.gearVariantsStr[4]);
                    stream.Read(ref record.gearVariantsStr[5]);
                    stream.Read(ref record.gearVariantsStr[6]);
                    stream.Read(ref record.gearVariantsStr[7]);
                    stream.Read(ref record.gearVariantsStr[8]);
                    stream.Read(ref record.gearVariantsStr[9]);
                    stream.Read(ref record.gearVariantsStr[10]);
                    stream.Read(ref record.gearVariantsStr[11]);
                    stream.Read(ref record.gearVariantsStr[12]);
                    stream.Read(ref record.gearVariantsStr[13]);
                    stream.Read(ref record.gearVariantsStr[14]);
                    stream.Read(ref record.gearVariantsStr[15]);
                record.hasLayer = new bool[16];
                    stream.Read(ref record.hasLayer[0]);
                    stream.Read(ref record.hasLayer[1]);
                    stream.Read(ref record.hasLayer[2]);
                    stream.Read(ref record.hasLayer[3]);
                    stream.Read(ref record.hasLayer[4]);
                    stream.Read(ref record.hasLayer[5]);
                    stream.Read(ref record.hasLayer[6]);
                    stream.Read(ref record.hasLayer[7]);
                    stream.Read(ref record.hasLayer[8]);
                    stream.Read(ref record.hasLayer[9]);
                    stream.Read(ref record.hasLayer[10]);
                    stream.Read(ref record.hasLayer[11]);
                    stream.Read(ref record.hasLayer[12]);
                    stream.Read(ref record.hasLayer[13]);
                    stream.Read(ref record.hasLayer[14]);
                    stream.Read(ref record.hasLayer[15]);
                stream.Read(ref record.totalPieces);
                record.hasMode = new bool[16];
                    stream.Read(ref record.hasMode[0]);
                    stream.Read(ref record.hasMode[1]);
                    stream.Read(ref record.hasMode[2]);
                    stream.Read(ref record.hasMode[3]);
                    stream.Read(ref record.hasMode[4]);
                    stream.Read(ref record.hasMode[5]);
                    stream.Read(ref record.hasMode[6]);
                    stream.Read(ref record.hasMode[7]);
                    stream.Read(ref record.hasMode[8]);
                    stream.Read(ref record.hasMode[9]);
                    stream.Read(ref record.hasMode[10]);
                    stream.Read(ref record.hasMode[11]);
                    stream.Read(ref record.hasMode[12]);
                    stream.Read(ref record.hasMode[13]);
                    stream.Read(ref record.hasMode[14]);
                    stream.Read(ref record.hasMode[15]);
                record.directionCount = new int[16];
                    stream.Read(ref record.directionCount[0]);
                    stream.Read(ref record.directionCount[1]);
                    stream.Read(ref record.directionCount[2]);
                    stream.Read(ref record.directionCount[3]);
                    stream.Read(ref record.directionCount[4]);
                    stream.Read(ref record.directionCount[5]);
                    stream.Read(ref record.directionCount[6]);
                    stream.Read(ref record.directionCount[7]);
                    stream.Read(ref record.directionCount[8]);
                    stream.Read(ref record.directionCount[9]);
                    stream.Read(ref record.directionCount[10]);
                    stream.Read(ref record.directionCount[11]);
                    stream.Read(ref record.directionCount[12]);
                    stream.Read(ref record.directionCount[13]);
                    stream.Read(ref record.directionCount[14]);
                    stream.Read(ref record.directionCount[15]);
                stream.Read(ref record.a1Moving);
                stream.Read(ref record.a2Moving);
                stream.Read(ref record.scMoving);
                stream.Read(ref record.s1Moving);
                stream.Read(ref record.s2Moving);
                stream.Read(ref record.s3Moving);
                stream.Read(ref record.s4Moving);
                stream.Read(ref record.noGfxHitTest);
                stream.Read(ref record.htTop);
                stream.Read(ref record.htLeft);
                stream.Read(ref record.htWidth);
                stream.Read(ref record.htHeight);
                stream.Read(ref record.restore);
                stream.Read(ref record.automapCel);
                stream.Read(ref record.noMap);
                stream.Read(ref record.noOvly);
                stream.Read(ref record.isSel);
                stream.Read(ref record.alSel);
                stream.Read(ref record.noSel);
                stream.Read(ref record.shiftSel);
                stream.Read(ref record.corpseSel);
                stream.Read(ref record.isAtt);
                stream.Read(ref record.revive);
                stream.Read(ref record.critter);
                stream.Read(ref record.small);
                stream.Read(ref record.large);
                stream.Read(ref record.soft);
                stream.Read(ref record.inert);
                stream.Read(ref record.objCol);
                stream.Read(ref record.deadCol);
                stream.Read(ref record.unflatDead);
                stream.Read(ref record.shadow);
                stream.Read(ref record.noUniqueShift);
                stream.Read(ref record.compositeDeath);
                stream.Read(ref record.localBlood);
                stream.Read(ref record.bleed);
                stream.Read(ref record.light);
                stream.Read(ref record.lightR);
                stream.Read(ref record.lightG);
                stream.Read(ref record.lightB);
                record.utrans = new int[3];
                    stream.Read(ref record.utrans[0]);
                    stream.Read(ref record.utrans[1]);
                    stream.Read(ref record.utrans[2]);
                stream.Read(ref record.heart);
                stream.Read(ref record.bodyPart);
                stream.Read(ref record.infernoLen);
                stream.Read(ref record.infernoAnim);
                stream.Read(ref record.infernoRollback);
                stream.Read(ref record.resurrectMode);
                stream.Read(ref record.resurrectSkill);
                stream.Read(ref record.eol);
    }
}
