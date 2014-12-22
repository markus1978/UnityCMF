package com.cubemonstergames.unitycmf.generators

import com.google.inject.Inject

class AbstractGenerator {
	
	@Inject public val ModelGenerator modelGenerator = null;
	@Inject public val MetaGenerator metaGenerator = null;
	@Inject public val ClassifierGenerator classifierGenerator = null;
	@Inject public val FeatureGenerator featureGenerator = null;
	@Inject public val ViewGenerator viewGenerator = null;
}