// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.FineTuning
{
    internal partial class FineTuningOptions
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public FineTuningOptions(InternalCreateFineTuningJobRequestModel model, string trainingFile)
        {
            Argument.AssertNotNull(trainingFile, nameof(trainingFile));

            Model = model;
            TrainingFile = trainingFile;
            Integrations = new ChangeTrackingList<FineTuningIntegration>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        internal FineTuningOptions(InternalCreateFineTuningJobRequestModel model, string trainingFile, HyperparameterOptions hyperparameters, string suffix, string validationFile, IList<FineTuningIntegration> integrations, int? seed, InternalTodoFineTuneMethod @method, IDictionary<string, string> metadata, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Model = model;
            TrainingFile = trainingFile;
            Hyperparameters = hyperparameters;
            Suffix = suffix;
            ValidationFile = validationFile;
            Integrations = integrations;
            Seed = seed;
            Method = @method;
            Metadata = metadata;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public InternalCreateFineTuningJobRequestModel Model { get; }

        public string TrainingFile { get; }

        public HyperparameterOptions Hyperparameters { get; set; }

        public string Suffix { get; set; }

        public string ValidationFile { get; set; }

        public IList<FineTuningIntegration> Integrations { get; set; }

        public int? Seed { get; set; }

        public InternalTodoFineTuneMethod Method { get; set; }

        public IDictionary<string, string> Metadata { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
