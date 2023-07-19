using Amazon.CDK;

namespace CdkPipelineEbDemo
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new CdkPipelineEbDemoStack(app, "CdkPipelineEbDemoStack");

            app.Synth();
        }
    }
}
