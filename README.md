# Ostrich-pattern
The Ostrich design pattern that solves many programming issues

Being a developer for over 30 years I have run into numerous issues where software sporadically failed because of corner cases that have not been handled. Investigations of these issues very often revealed that very specific conditions were met resulting in the failure. In quite some situations where it was my own software under investigation I instantly recognised the problem as having it set aside during initial development. Even worse, I am ashamed to admit that at times when issues materialized, I instantly had an idea of how and why it happened without needing further details or investigations.

Thinking back of how these situations arose I often found (and still find) myself saying things as 'unlikely to happen', 'should not happen', 'not important', 'we should do that' or 'yes but not now'. At best some todos were added at the code and that would be it until something bad happened. Speaking for myself and for others based on their code I dealt with, I see the following reasons this pattern to appear;

* time pressure - we need this in 2 days
* unclear requirements - this should cover it all
* laziness - that is a lot of work for something that is unlikely to happen
* incompetence - simply not knowing how to solve it properly

I often see this same pattern arising in requirements/specification/architecture where people involved in a specification process know that an issue is there, but since the problem is too hard it is either oversimplified or silently ignored in the hope that if the issue materializes, the developers will solve it.

As I recognized the pattern that occurred I decided to name it the The Ostrich Pattern. Me and my colleagues now use it regularly and we instantly know what is happening when it is mentioned by someone. That said we unfortunately still apply the pattern. So being primarily a developer I decided to do something code-wise to alleviate the problem somewhat. The solution involves an C# attribute/Java notation that are used to explicitly denote a piece of code that contains a recognized Ostrich pattern. Other developers will then know that there something fishy that still need attention.
