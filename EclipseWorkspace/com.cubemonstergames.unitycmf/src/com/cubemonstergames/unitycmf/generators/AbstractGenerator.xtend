package com.cubemonstergames.unitycmf.generators

import com.google.inject.Inject

class AbstractGenerator {
	
	@Inject protected val ModelGenerator modelGenerator = null;
	@Inject protected val MetaGenerator metaGenerator = null;
	@Inject protected val ClassifierGenerator classifierGenerator = null;
	@Inject protected val FeatureGenerator featureGenerator = null;
	@Inject protected val ViewGenerator viewGenerator = null;
}