using System;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using LambdaSharp;
using LambdaSharp.Finalizer;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Challenge.LambdaRobots.Server.Finalizer {

    public class Function : ALambdaFinalizerFunction {

        //--- Methods ---
        public override async Task InitializeAsync(LambdaConfig config) {

            // TO-DO: add function initialization and reading configuration settings
        }

        public override async Task CreateDeployment(FinalizerProperties current) {

            // TO-DO: add business logic when creating a module deployment
        }

        public override async Task UpdateDeployment(FinalizerProperties next, FinalizerProperties previous) {

            // TO-DO: add business logic when updating a module deployment
        }

        public override async Task DeleteDeployment(FinalizerProperties current) {

            // TO-DO: add business logic when deleting a module deployment
            //  * stop all game loop step-functions that are in progress
        }
    }
}
